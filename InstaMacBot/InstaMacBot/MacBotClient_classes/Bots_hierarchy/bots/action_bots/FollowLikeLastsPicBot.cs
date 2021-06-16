using InstagramApiSharp;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMacBot.InstaMacBot
{
    class FollowLikeLastsPicBot : SSSBot
    {
        //OVERVIEW: this class represents a follow, like lasts pics bot that with a list of username for each username on list
        //          follow and like lasts pics
        //          objects of this class are mutable

        private int likes, follow;
        private List<string> processing_accounts_list;
        private List<string> followed_list;
        private UserApi UtenteApi;
        private int stop_fails_search_user;
        private int like_lasts_pic;
        private int stop_fails_like;
        private int stop_fails_follow;
        private int delay;
        private bool skip_following;
        private bool follow_account;
        private Action actions_bot_finshed;
        private string path_bot_save_info;

        public int get_account_rocessing_counts { get { return processing_accounts_list.Count; } }
        public int get_likes { get { return likes; } }
        public int get_follow { get { return follow; } }
        public FollowLikeLastsPicBot(UserApi Utente, string path_bot_save_info, BotConsole tx_console = null, int stop_fails_search_user = 20, int like_lasts_pic = 1, bool follow_accounts=true, int stop_fails_like = 5, int stop_fails_follow = 5, int delay = 40, bool skip_following = false, Action actions = null) : base(tx_console)
        {
            if(Utente==null) throw new ArgumentNullException("utente must be != null");
            if (like_lasts_pic > 3 || like_lasts_pic <= 0) throw new ArgumentOutOfRangeException("like_lasts_pic must be > 0 and <= 3");
            if (stop_fails_search_user <=0) throw new ArgumentOutOfRangeException("stop_fails_search_user must be > 0");
            if (stop_fails_like <=0) throw new ArgumentOutOfRangeException("stop_fails_like must be > 0");
            if (stop_fails_follow <=0) throw new ArgumentOutOfRangeException("stop_fails_follow must be > 0");
            if (delay < 0) throw new ArgumentOutOfRangeException("stop_fails_follow must be >=0");

            likes = 0;
            follow = 0;
            processing_accounts_list = new List<string>();
            followed_list = new List<string>();
            UtenteApi = Utente;
            this.stop_fails_search_user = stop_fails_search_user;
            this.like_lasts_pic = like_lasts_pic;
            this.stop_fails_like = stop_fails_like;
            this.stop_fails_follow = stop_fails_follow;
            this.delay = delay;
            this.skip_following = skip_following;
            this.follow_account = follow_accounts;
            actions_bot_finshed = actions;
            this.path_bot_save_info = path_bot_save_info;


        }

        public bool set_likes_last_pic(int i)
        {
            if (i < 0 || i > 3)
                return false;

            like_lasts_pic = i;
            return true;
            
        }

        public void set_follow_accounts(bool i)
        {
            follow_account = i;
        }


        public bool set_delay(int i)
        {
            if (i < 30)
                return false;

            delay = i;
            return true;

        }

        public override void start()
        {
            status = true;
            procedura_bot();
        }

        public override void stop(bool save_infos)
        {
            if (save_infos)
            {
                save_on_file_accounts_not_proccessed_list_bot_file_saver(path_bot_save_info);
                save_on_file_accounts_followed_list_bot_file_saver(path_bot_save_info);                
            }
            status = false;
            console.write_on_console("bot ended");
            actions_bot_finshed();
        }

        //BOT

        private async Task<InstaMediaList> lasts_media_id(string username)
        {

            IResult<InstaMediaList> list_media_id = await UtenteApi.lasts_media_id(username);

            if (list_media_id.Succeeded && list_media_id.Value.Count > 0)
            {
                return list_media_id.Value;
            }
            else
            {
                return null;
            }

        }

        private async Task<bool> wait(int secondi)
        {
            int i = 0;
            while (i < secondi && status)
            {
                await Task.Delay(1000);
                i++;
            }
            return true;
        }



        private async void procedura_bot()
        {
            if (processing_accounts_list.Count == 0)
            {
                console.write_on_console("no accounts loaded");
                stop(false);
                actions_bot_finshed();
                return;
            }


            int like_fail = 0;
            int follow_fail = 0;
            int search_fail = 0;
            likes = 0;
            follow = 0;
            followed_list.Clear();
            HashSet<string> following = null;
            if (skip_following)
            {
                console.write_on_console("extracting your following...");
                following = await UtenteApi.get_following();
            }

            while (processing_accounts_list.Count > 0 && status)
            {
                bool privato;
                do
                {
                    IResult<InstaUser> utente_in_elaborazione = await UtenteApi.get_user(processing_accounts_list[0]);

                    if (utente_in_elaborazione.Value != null)
                    {
                        if (search_fail != 0)
                        {
                            search_fail = 0;
                        }

                        privato = utente_in_elaborazione.Value.IsPrivate;

                        if (privato)
                        {
                            console.write_on_console("private account skipped: " + processing_accounts_list[0]);
                            processing_accounts_list.RemoveAt(0);
                        }
                    }
                    else
                    {
                        console.write_on_console("account not found skipped: " + processing_accounts_list[0] + " [search fail = " + search_fail + "]");

                        privato = true; //usato per skippare ma l'account non è stato proprio trovato
                        processing_accounts_list.RemoveAt(0);

                        search_fail++;
                        if (search_fail > stop_fails_search_user)
                        {
                            //MessageBox.Show("errore sugli ultimi 20 account: stop di sicurezza");
                            console.write_on_console("stop fails reach [ "+ stop_fails_search_user+" ], securestop");
                            stop(true);
                            return;

                        }
                    }
                } while (privato);

                if (skip_following)
                {
                    if (following.Contains(processing_accounts_list[0]))
                    {
                        console.write_on_console("skipped " + processing_accounts_list[0] + " because you already follow him");
                        processing_accounts_list.RemoveAt(0);
                        continue;
                    }
                }


                InstaMediaList foto = null;
               
                foto = await lasts_media_id(processing_accounts_list[0]);
                if (foto == null)
                {
                    console.write_on_console("no photo account skipped: " + processing_accounts_list[0]);
                    processing_accounts_list.RemoveAt(0);
                    continue;
                }

                //foto estratte

                int i = 0;
                while ( i<like_lasts_pic && i<foto.Count)
                {
                    bool like_messo = await UtenteApi.put_like(foto[i].InstaIdentifier);
                   

                    if (like_messo)
                    {
                        likes++;
                        int k = i + 1;
                        console.write_on_console("like last "+ k +" foto of: " + processing_accounts_list[0] + " [tot: " + likes + "]");
                        if (like_fail != 0)
                        {
                            like_fail = 0;
                        }
                        else
                        {
                            like_fail++;
                            if (like_fail > stop_fails_like)
                            {
                                console.write_on_console("bot reached likes fails [ "+ stop_fails_like + " ] secure stop");
                                stop(true);
                                return;
                                
                            }
                        }
                    }
                    i++;
                }

                if (follow_account)
                {
                    bool follow_messo = await UtenteApi.follow(processing_accounts_list[0]);

                    if (follow_messo)
                    {
                        followed_list.Add(processing_accounts_list[0]);
                        follow++;
                        console.write_on_console("followed: " + processing_accounts_list[0] + " [tot: " + follow + "]");
                        if (follow_fail != 0)
                        {
                            follow_fail = 0;
                        }
                    }
                    else
                    {
                        follow_fail++;
                        if (follow_fail > stop_fails_follow)
                        {

                            console.write_on_console("bot reached follow fails [ " + stop_fails_follow + " ] secure stop");
                            stop(true);
                            return;
                        }
                    }
                }
                
                processing_accounts_list.RemoveAt(0);
                await wait(delay);
            }



            if (status)
                stop(true);

        }



        public void clear_processing_accounts_list()
        {
            processing_accounts_list.Clear();
            console.write_on_console("processing account list cleared");
        }


        public void load_list_from_file()
        {
            clear_processing_accounts_list();

            string path;
            string line;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;

                using (StreamReader reader = new StreamReader(path))
                {

                    while ((line = reader.ReadLine()) != null)
                    {
                        processing_accounts_list.Add(line);
                    }
                }
                console.write_on_console("loaded: " + processing_accounts_list.Count.ToString() + " Accounts");
                    
            }
        }

        public void load_list_from_file(string path)
        {
            clear_processing_accounts_list();

            string line;

            using (StreamReader reader = new StreamReader(path))
            {

                while ((line = reader.ReadLine()) != null)
                {
                    processing_accounts_list.Add(line);
                }
            }
            console.write_on_console("loaded: " + processing_accounts_list.Count.ToString() + " Accounts");

            
        }


        public void save_on_file_accounts_not_proccessed_list_bot_file_saver(string path_account)
        {
            BotFileSaver save_file = new DesktopBotFileSaver(path_account + "/left accounts (follow like bot).txt", true);
            save_file.write_list_on_file(processing_accounts_list);
            console.write_on_console("Accounts not processed saved in the list: left accounts (follow like bot)");
            
        }

        public void save_on_file_accounts_followed_list_bot_file_saver(string path_account)
        {
            BotFileSaver save_file = new DesktopBotFileSaver(path_account + "/followed (follow like bot).txt", false);

            if (followed_list.Count > 0)
            {
                save_file.write_list_on_file(followed_list);
                console.write_on_console("followed accounts appended in the list: followed (follow like bot)");
            }
        }


    }
}

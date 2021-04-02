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

namespace InstaMacBot.classi_MacBotClient
{
    class FollowLikeLastsPicBot : SSSBot
    {
        //OVERVIEW: this class represents a follow, like lasts pics bot that with a list of username for each username on list
        //          follow and like lasts pics
        //          objects of this class are mutable

        private int likes, follow;
        private List<string> processing_accounts_list;
        private List<string> followed_list;
        private bool stop_bot;
        private UserApi UtenteApi;
        private int stop_fails_search_user;
        private int like_lasts_pic;
        private int stop_fails_like;
        private int stop_fails_follow;
        private int delay;
        private bool skip_following;

        public int get_account_rocessing_counts { get { return processing_accounts_list.Count; } }
        public int get_likes { get { return likes; } }
        public int get_follow { get { return follow; } }
        public FollowLikeLastsPicBot(UserApi Utente, TextBox tx_console = null, Label OnOf = null, int stop_fails_search_user = 20, int like_lasts_pic = 1, int stop_fails_like = 5, int stop_fails_follow = 5, int delay = 40, bool skip_following = false) : base(tx_console)
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
            stop_bot = true;
            UtenteApi = Utente;
            this.stop_fails_search_user = stop_fails_search_user;
            this.like_lasts_pic = like_lasts_pic;
            this.stop_fails_like = stop_fails_like;
            this.stop_fails_follow = stop_fails_follow;
            this.delay = delay;
            this.skip_following = skip_following;
            
        }

        public override void start()
        {
            stop_bot = false;
            status = true;
            procedura_bot();
        }

        public override void stop(bool save_infos)
        {
            if (save_infos)
            {
                save_on_file_accounts_followed();
                save_on_file_accounts_not_proccessed();
            }
            stop_bot = true;
            status = false;
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
            while (i < secondi && !stop_bot)
            {
                await Task.Delay(1000);
                i++;
            }
            return true;
        }



        private async void procedura_bot()
        {
            int like_fail = 0;
            int follow_fail = 0;
            int search_fail = 0;
            likes = 0;
            follow = 0;
            followed_list.Clear();
            HashSet<string> following = null;
            if (skip_following)
            {
                write_on_console("extracting your following...");
                following = await UtenteApi.get_following();
            }

            while (processing_accounts_list.Count > 0 && !stop_bot)
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
                            write_on_console("private account skipped: " + processing_accounts_list[0]);
                            processing_accounts_list.RemoveAt(0);
                        }
                    }
                    else
                    {
                        write_on_console("account not found skipped: " + processing_accounts_list[0] + " [search fail = " + search_fail + "]");

                        privato = true; //usato per skippare ma l'account non è stato proprio trovato
                        processing_accounts_list.RemoveAt(0);

                        search_fail++;
                        if (search_fail > stop_fails_search_user)
                        {
                            //MessageBox.Show("errore sugli ultimi 20 account: stop di sicurezza");
                            write_on_console("stop fails reach [ "+ stop_fails_search_user+" ], securestop");
                            stop(true);
                            return;

                        }
                    }
                } while (privato);

                if (skip_following)
                {
                    if (following.Contains(processing_accounts_list[0]))
                    {
                        write_on_console("skipped " + processing_accounts_list[0] + " because you already follow him");
                        processing_accounts_list.RemoveAt(0);
                        continue;
                    }
                }


                InstaMediaList foto = null;
               
                foto = await lasts_media_id(processing_accounts_list[0]);
                if (foto == null)
                {
                    write_on_console("no photo account skipped: " + processing_accounts_list[0]);
                    processing_accounts_list.RemoveAt(0);
                    continue;
                }

                //foto estratte


                for(int i=0; i<like_lasts_pic && i<foto.Count; i++)
                {
                    bool like_messo = await UtenteApi.put_like(foto[i].InstaIdentifier);
                   

                    if (like_messo)
                    {
                        likes++;
                        write_on_console("like lasts "+ like_lasts_pic +" foto of: " + processing_accounts_list[0] + " [tot: " + likes + "]");
                        if (like_fail != 0)
                        {
                            like_fail = 0;
                        }
                        else
                        {
                            like_fail++;
                            if (like_fail > stop_fails_like)
                            {
                                write_on_console("bot reached likes fails [ "+ stop_fails_like + " ] secure stop");
                                stop(true);
                                return;
                                
                            }
                        }
                    }
                }

                bool follow_messo = await UtenteApi.follow(processing_accounts_list[0]);

                if (follow_messo)
                {
                    followed_list.Add(processing_accounts_list[0]);
                    follow++;
                    write_on_console("followed: " + processing_accounts_list[0] + " [tot: " + follow + "]");
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

                        write_on_console("bot reached follow fails [ " + stop_fails_follow + " ] secure stop");
                        stop(true);
                        return;
                    }
                }

                
                processing_accounts_list.RemoveAt(0);
                await wait(delay);
            }

            write_on_console("bot ended");
            stop(false);
        }



        public void clear_processing_accounts_list()
        {
            processing_accounts_list.Clear();
            write_on_console("processing account list cleared");
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
                write_on_console("loaded: " + processing_accounts_list.Count.ToString() + " Accounts");
                    
            }
        }


        public void save_on_file_accounts_not_proccessed()
        {
           
           
            if (processing_accounts_list.Count > 0)
            {
               

                bool exists = System.IO.Directory.Exists("FollowLikeLastsPicBot");

                if (!exists)
                    System.IO.Directory.CreateDirectory("FollowLikeLastsPicBot");

                using (StreamWriter scrivi = new StreamWriter("FollowLikeLastsPicBot/left.txt"))
                {
                    for (int i = 0; i < processing_accounts_list.Count(); i++)
                    {
                        scrivi.WriteLine(processing_accounts_list[i]);
                    }
                }

                write_on_console("Accounts not processed saved in 'FollowLikeLastsPicBot/left.txt'");
            }
            else
            {
                bool exists = System.IO.Directory.Exists("FollowLikeLastsPicBot");

                if (!exists)
                    System.IO.Directory.CreateDirectory("FollowLikeLastsPicBot");

                using (StreamWriter scrivi = new StreamWriter("FollowLikeLastsPicBot/left.txt"))
                {
                    scrivi.WriteLine("");
                }

                write_on_console("Accounts not processed saved in 'FollowLikeLastsPicBot/left.txt'");
            }
            
        }

        public void save_on_file_accounts_followed()
        {
            if (followed_list.Count > 0)
            {
                bool exists = System.IO.Directory.Exists("FollowLikeLastsPicBot");

                if (!exists)
                    System.IO.Directory.CreateDirectory("FollowLikeLastsPicBot");

                using (StreamWriter scrivi = File.AppendText("FollowLikeLastsPicBot/followed.txt"))
                {
                    for (int i = 0; i < followed_list.Count(); i++)
                    {
                        scrivi.WriteLine(followed_list[i]);
                    }
                }
                write_on_console("followed accounts added in 'FollowLikeLastsPicBot/followed.txt'");
            }
        }

       
    }
}

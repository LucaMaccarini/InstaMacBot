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
    class UnfollowBot : SSSBot
    {
        //OVERVIEW: this class represents an unfollow bot that with a list of username unfollow all users on the list
        //          objects of this class are mutable

        private int unfollow;
        private List<string> followed_list;
        private List<string> error_unfollowed_list;
        private UserApi UtenteApi;
        private int stop_fails_search_user;
        private int stop_fails_unfollow;
        private int delay;
        private string file_followed_accounts_path;
        private bool skip_non_following;
        private Action actions_bot_finshed;
        private string path_bot_save_info;


        public int get_unfollow { get { return unfollow; } }
        public UnfollowBot(UserApi Utente, string path_bot_save_info, BotConsole tx_console = null, int stop_fails_search_user = 20, int stop_fails_unfollow = 5, int delay = 50, bool skip_non_following = false, Action actions = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente must be != null");
            if (stop_fails_search_user <= 0) throw new ArgumentOutOfRangeException("stop_fails_search_user must be > 0");
            if (delay < 0) throw new ArgumentOutOfRangeException("stop_fails_follow must be >= 0");

            unfollow = 0;
            followed_list = new List<string>();
            error_unfollowed_list = new List<string>();
            UtenteApi = Utente;
            this.stop_fails_search_user = stop_fails_search_user;
            this.stop_fails_unfollow = stop_fails_unfollow;
            this.delay = delay;
            this.skip_non_following = skip_non_following;
            actions_bot_finshed = actions;
            this.path_bot_save_info = path_bot_save_info;
        }

        public bool set_delay(int i)
        {
            if (i < 40)
                return false;

            delay = i;
            return true;

        }


        public override void start()
        {
            status = true;
            bot_procedure();
        }
        //fix
        public override void stop(bool save_infos)
        {
            if (save_infos)
            {
                save_on_file_accounts_not_proccessed_list_bot_file_saver(path_bot_save_info);
                save_on_file_error_unfollow_list_bot_file_saver(path_bot_save_info);
            }
            status = false;
            actions_bot_finshed();
            console.write_on_console("bot ended");
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

        private async void bot_procedure()
        {
            if (followed_list.Count == 0)
            {
                console.write_on_console("no accounts followed loaded");
                stop(false);
                
                return;
            }

            error_unfollowed_list.Clear();
            unfollow = 0;
            int fails_search_user = 0;
            HashSet<string> x=null;
            if (skip_non_following)
            {
                console.write_on_console("extracting your following...");
                x = await UtenteApi.get_following();
            }
            while (followed_list.Count > 0 && status)
            {

                IResult<InstaUserInfo> utente;
                bool errore;
                do
                {
                    errore = false;
                    utente = await UtenteApi.get_user_info(followed_list[0]);

                    if (utente.Value == null)
                    {
                        console.write_on_console("account not found skipped: " + followed_list[0]);
                        errore = true;

                        error_unfollowed_list.Add(followed_list[0]);
                        followed_list.RemoveAt(0);

                        fails_search_user++;

                        if (fails_search_user > stop_fails_search_user)
                        {
                            console.write_on_console("error stop unfollow fail reach: secure stop");
                            stop(true);
                            return;

                        }
                    }
                    else
                    {
                        if (fails_search_user != 0)
                        {
                            fails_search_user = 0;
                        }

                    }

                } while (errore && followed_list.Count>0);


                if (followed_list.Count == 0)
                {
                    stop(true);
                    return;
                }

                if (skip_non_following)
                {
                    if (!(x.Contains(followed_list[0])))
                    {
                        console.write_on_console("skipped " + followed_list[0] + " cause you don't follow him");
                        followed_list.RemoveAt(0);
                        continue;
                    }
                }

                bool esito = await UtenteApi.unfollow(utente.Value.Pk);


                if (esito)
                {
                   
                    unfollow++;

                    console.write_on_console("unfollowed: " + followed_list[0] + " [tot: " + unfollow +"]");
                }
                else
                {
                    error_unfollowed_list.Add(followed_list[0]);
                    console.write_on_console("unfollow error" + followed_list[0]);
                }

                followed_list.RemoveAt(0);
                await wait(delay);
            }

            

            if (status)
                stop(true);
        }


        public void load_followed_accounts()
        {
            clear_followed_list();
            string path_file_seguiti;
            string line;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path_file_seguiti = openFileDialog.FileName;
                file_followed_accounts_path = path_file_seguiti;
                using (StreamReader reader = new StreamReader(path_file_seguiti))
                {

                    while ((line = reader.ReadLine()) != null)
                    {
                        followed_list.Add(line);
                    }
                }
                console.write_on_console("account loaded: " + followed_list.Count);


            }
        }

        public void load_followed_accounts(string path)
        {
            file_followed_accounts_path = path;
            clear_followed_list();
            string line;

           
            using (StreamReader reader = new StreamReader(path))
            {

                while ((line = reader.ReadLine()) != null)
                {
                    followed_list.Add(line);
                }
            }
            console.write_on_console("account loaded: " + followed_list.Count);


            
        }

        public void clear_followed_list()
        {
            followed_list.Clear();
            console.write_on_console("followed list cleared");
        }


        public void save_on_file_accounts_not_proccessed_list_bot_file_saver(string account_path)
        {


            bool exists = File.Exists(file_followed_accounts_path);
            if (!exists)
            {
                if (followed_list.Count > 0)
                {
                    console.write_on_console("source list was deleted by someone, so i create a new list with all not processed accounts");

                    BotFileSaver save_file = new DesktopBotFileSaver(account_path + "/left to unfollow (unfollowed bot).txt", true);
                    save_file.write_list_on_file(followed_list);
                    console.write_on_console("Accounts not processed saved in the list: left to unfollow (unfollowed bot)");
                }
            }
            else
            {
                BotFileSaver save_file = new DesktopBotFileSaver(file_followed_accounts_path, true);
                save_file.write_list_on_file(followed_list);
                string[] path_splitted = file_followed_accounts_path.Split('/');
                console.write_on_console("Removed the unfollowed accounts from the source list: " + path_splitted[path_splitted.Length-1].Split('.')[0]);
            }            

        }





        public void save_on_file_error_unfollow_list_bot_file_saver(string path_account)
        {
           
            if (error_unfollowed_list.Count > 0)
            {
                BotFileSaver save_file = new DesktopBotFileSaver(path_account + "/errors unfollow (unfollow bot).txt", false);
                save_file.write_list_on_file(error_unfollowed_list);
                console.write_on_console("Error operations on Accounts saved in the list: errors unfollow (unfollow bot)");

            }

        }
    }
}

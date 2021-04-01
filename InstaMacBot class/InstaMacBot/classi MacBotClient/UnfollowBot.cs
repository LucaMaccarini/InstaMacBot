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
    class UnfollowBot : SSSBot
    {
        //OVERVIEW: this class represents an unfollow bot that with a list of username unfollow all users on the list
        //          objects of this class are mutable

        private int unfollow;
        private List<string> followed_list;
        private List<string> error_unfollowed_list;
        private bool stop_bot;
        private UserApi UtenteApi;
        private int stop_fails_search_user;
        private int stop_fails_unfollow;
        private int delay;


        public int get_unfollow { get { return unfollow; } }
        public UnfollowBot(UserApi Utente, TextBox tx_console = null, int stop_fails_search_user = 20, int stop_fails_unfollow = 5, int delay = 40) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente must be != null");
            if (stop_fails_search_user <= 0) throw new ArgumentOutOfRangeException("stop_fails_search_user must be > 0");
            if (delay < 0) throw new ArgumentOutOfRangeException("stop_fails_follow must be >= 0");

            unfollow = 0;
            followed_list = new List<string>();
            error_unfollowed_list = new List<string>();
            stop_bot = true;
            UtenteApi = Utente;
            this.stop_fails_search_user = stop_fails_search_user;
            this.stop_fails_unfollow = stop_fails_unfollow;
            this.delay = delay;
        }

        public override void start()
        {
            stop_bot = false;
            status = true;
            bot_procedure();
        }

        public override void stop()
        {
            stop_bot = true;
            status = false;
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

        private async void bot_procedure()
        {
            error_unfollowed_list.Clear();
            clear_followed_list();
            unfollow = 0;
            int fails_search_user = 0;
            while (followed_list.Count > 0 && !stop_bot)
            {

                IResult<InstaUserInfo> utente;
                bool errore;
                do
                {
                    errore = false;
                    utente = await UtenteApi.get_user_info(followed_list[0]);

                    if (utente.Value == null)
                    {
                        write_on_console("account not found skipped: " + followed_list[0]);
                        errore = true;

                        error_unfollowed_list.Add(followed_list[0]);
                        followed_list.RemoveAt(0);

                        fails_search_user++;

                        if (fails_search_user > stop_fails_search_user)
                        {
                            write_on_console("error stop unfollow fail reach: secure stop");
                            stop();
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
                    stop();
                    write_on_console("bot ended");
                    return;
                }

                bool esito = await UtenteApi.unfollow(utente.Value.Pk);


                if (esito)
                {
                   
                    unfollow++;

                    write_on_console("unfollowed: " + followed_list[0] + " [tot: " + unfollow +"]");
                }
                else
                {
                    error_unfollowed_list.Add(followed_list[0]);
                    write_on_console("unfollow error" + followed_list[0]);
                }

                followed_list.RemoveAt(0);
                await wait(delay);
            }
            write_on_console("bot ended");
            stop();
        }


        public void load_followed_accounts()
        {
            followed_list.Clear();
            string path_file_seguiti;
            string line;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path_file_seguiti = openFileDialog.FileName;

                using (StreamReader reader = new StreamReader(path_file_seguiti))
                {

                    while ((line = reader.ReadLine()) != null)
                    {
                        followed_list.Add(line);
                    }
                }
                write_on_console("account loaded: " + followed_list.Count);


            }
        }

        public void save_on_file_error_unfollow()
        {
            if (error_unfollowed_list.Count > 0)
            {

                bool exists = System.IO.Directory.Exists("UnfollowBot");

                if (!exists)
                    System.IO.Directory.CreateDirectory("UnfollowBot");

                using (StreamWriter scrivi = File.AppendText("UnfollowBot/error_unfollow.txt"))
                {
                    for (int i = 0; i < error_unfollowed_list.Count(); i++)
                    {
                        scrivi.WriteLine(error_unfollowed_list[i]);
                    }
                }

            }
        }

        public void clear_followed_list()
        {
            followed_list.Clear();
            write_on_console("followed list cleared");
        }

        public void save_on_file_accounts_not_proccessed()
        {


            if (followed_list.Count > 0)
            {
                MessageBox.Show("bot didn't process all account loaded the rest of accounts are saved in 'leftFollowed.txt'", "accounts left");

                bool exists = System.IO.Directory.Exists("UnfollowBot");

                if (!exists)
                    System.IO.Directory.CreateDirectory("UnfollowBot");

                using (StreamWriter scrivi = new StreamWriter("unfollow/leftFollowed.txt"))
                {
                    for (int i = 0; i < followed_list.Count(); i++)
                    {
                        scrivi.WriteLine(followed_list[i]);
                    }
                }
            }

        }
    }
}

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
    class SendDmBot : SSSBot
    {
        //OVERVIEW: this class represents a send dms bot that with a list of username for each username on list
        //          send a dm
        //          objects of this class are mutable

        private int dms;
        private List<string> processing_accounts_list;
        private UserApi UtenteApi;
        private int stop_fails_search_user;
        private int stop_fails_send_dm;
        private int delay;
        private string message;
        private string link;
        private Action actions_bot_finshed;
        private string path_bot_save_info;

        public SendDmBot(UserApi Utente, string path_bot_save_info, BotConsole tx_console = null, int stop_fails_search_user = 20, string message="", string link="", int stop_fails_send_dm = 5, int delay = 40, Action actions = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente must be != null");
            if (stop_fails_search_user <= 0) throw new ArgumentOutOfRangeException("stop_fails_search_user must be > 0");
            if (stop_fails_send_dm <= 0) throw new ArgumentOutOfRangeException("stop_fails_send_dm must be > 0");
            if (delay < 0) throw new ArgumentOutOfRangeException("stop_fails_follow must be >=0");

            this.dms = 0;
            processing_accounts_list = new List<string>();
            this.UtenteApi = Utente;
            this.stop_fails_search_user = stop_fails_search_user;
            this.stop_fails_send_dm = stop_fails_send_dm;
            this.delay = delay;
            this.message = message;
            this.link = link;
            this.actions_bot_finshed = actions;
            this.path_bot_save_info = path_bot_save_info;
        }

        public string get_message()
        {
            return message;
        }
        public void set_message(string message)
        {
            this.message = message;
        }

        public void set_link(string link)
        {
            this.link = link;
        }

        public string get_link()
        {
            return link;
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


        //fix
        public override void stop(bool save_infos=false)
        {
            if (save_infos)          
                save_on_file_accounts_not_proccessed_list_bot_file_saver(path_bot_save_info);
            
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
        public void clear_processing_accounts_list()
        {
            processing_accounts_list.Clear();
            console.write_on_console("processing account list cleared");
        }

        private async void procedura_bot()
        {
            int dm_fail = 0;
            int search_fail = 0;
            dms = 0;

            if (processing_accounts_list.Count == 0)
            {
                console.write_on_console("no accounts loaded");
                stop();
                return;
            }


            if (message == "")
            {
                console.write_on_console("empty message");
                stop();
                return;
            }

            while (processing_accounts_list.Count > 0 && status)
            {
                bool not_found;
                do
                {
                    IResult<InstaUser> utente_in_elaborazione = await UtenteApi.get_user(processing_accounts_list[0]);

                    if (utente_in_elaborazione.Value != null)
                    {
                        if (search_fail != 0)
                        {
                            search_fail = 0;
                        }

                        not_found = false;
                       
                    }
                    else
                    {
                        console.write_on_console("account not found skipped: " + processing_accounts_list[0] + " [search fail = " + search_fail + "]");

                        not_found = true;
                        processing_accounts_list.RemoveAt(0);

                        search_fail++;
                        if (search_fail > stop_fails_search_user)
                        {
                            //MessageBox.Show("errore sugli ultimi 20 account: stop di sicurezza");
                            console.write_on_console("stop fails reach [ " + stop_fails_search_user + " ], securestop");
                            stop();
                            return;

                        }
                    }
                } while (not_found);

               
                bool dm_sent = await UtenteApi.send_dm_text(message,processing_accounts_list[0]);


                /*if (link != "")
                {
                    bool link_sent = await UtenteApi.send_dm_link(link, processing_accounts_list[0]);

                    if (!link_sent)
                        tx_console.write_on_console("failed link sent to:" + processing_accounts_list[0]);
                }*/



               if (dm_sent)
               {
                    dms++;
                    console.write_on_console("dm sent to: " + processing_accounts_list[0] + " [tot: " + dms + "]");
                    if (dm_fail != 0)
                    {
                        dm_fail = 0;
                    }
               }
                else
                {
                    dm_fail++;
                    console.write_on_console("fasiled sent dm to: " + processing_accounts_list[0]);
                    if (dm_fail > stop_fails_send_dm)
                    {
                        console.write_on_console("bot reached dm fails [ " + stop_fails_send_dm + " ] secure stop");
                        stop(true);
                        return;

                    }
                }

                processing_accounts_list.RemoveAt(0);
                await wait(delay);
            }

            if (status)
            {
                stop(true);
            }
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

        public void load_followed_accounts(string path)
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
            console.write_on_console("account loaded: " + processing_accounts_list.Count);
        }

        public void save_on_file_accounts_not_proccessed_list_bot_file_saver(string path_account)
        {
            BotFileSaver save_file = new DesktopBotFileSaver(path_account + "/left DM accounts (send dm bot).txt", true);
            save_file.write_list_on_file(processing_accounts_list);
            console.write_on_console("Accounts not processed saved in the list: left DM accounts (send dm bot)");

        }

    }
}

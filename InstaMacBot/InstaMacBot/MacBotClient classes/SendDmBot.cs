using InstagramApiSharp;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstaMacBot.classi_MacBotClient;
using InstaMacBot.MacBotClient_classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMacBot.MacBotClient_classes
{
    class SendDmBot : SSSBot
    {
        //OVERVIEW: this class represents a send dms bot that with a list of username for each username on list
        //          send a dm
        //          objects of this class are mutable

        private int dms;
        private List<string> processing_accounts_list;
        private bool stop_bot;
        private UserApi UtenteApi;
        private int stop_fails_search_user;
        private int stop_fails_send_dm;
        private int delay;
        private string message;

        public SendDmBot(UserApi Utente, BotConsole tx_console = null, int stop_fails_search_user = 20, string message="", int stop_fails_send_dm = 5, int delay = 40) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente must be != null");
            if (stop_fails_search_user <= 0) throw new ArgumentOutOfRangeException("stop_fails_search_user must be > 0");
            if (stop_fails_send_dm <= 0) throw new ArgumentOutOfRangeException("stop_fails_send_dm must be > 0");
            if (delay < 0) throw new ArgumentOutOfRangeException("stop_fails_follow must be >=0");

            this.dms = 0;
            processing_accounts_list = new List<string>();
            stop_bot = true;
            this.UtenteApi = Utente;
            this.stop_fails_search_user = stop_fails_search_user;
            this.stop_fails_send_dm = stop_fails_send_dm;
            this.delay = delay;
            this.message = message;
        }

        public string get_message()
        {
            return message;
        }
        public void set_message(string message)
        {
            this.message = message;
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
            stop_bot = false;
            status = true;
            procedura_bot();
        }

        public override void stop(bool save_infos)
        {
            if (save_infos)
            {
                save_on_file_accounts_not_proccessed();
            }
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
        public void clear_processing_accounts_list()
        {
            processing_accounts_list.Clear();
            tx_console.write_on_console("processing account list cleared");
        }

        private async void procedura_bot()
        {
            int dm_fail = 0;
            int search_fail = 0;
            dms = 0;

            while (processing_accounts_list.Count > 0 && !stop_bot)
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
                        /*
                        privato = utente_in_elaborazione.Value.IsPrivate;

                        if (privato)
                        {
                            tx_console.write_on_console("private account skipped: " + processing_accounts_list[0]);
                            processing_accounts_list.RemoveAt(0);
                        }*/
                    }
                    else
                    {
                        tx_console.write_on_console("account not found skipped: " + processing_accounts_list[0] + " [search fail = " + search_fail + "]");

                        not_found = true;
                        processing_accounts_list.RemoveAt(0);

                        search_fail++;
                        if (search_fail > stop_fails_search_user)
                        {
                            //MessageBox.Show("errore sugli ultimi 20 account: stop di sicurezza");
                            tx_console.write_on_console("stop fails reach [ " + stop_fails_search_user + " ], securestop");
                            stop(true);
                            return;

                        }
                    }
                } while (not_found);




                bool dm_sent = await UtenteApi.send_dm_text(message,processing_accounts_list[0]);


                if (dm_sent)
                {
                    dms++;
                    tx_console.write_on_console("dm sent to: " + processing_accounts_list[0] + " [tot: " + dms + "]");
                    if (dm_fail != 0)
                    {
                        dm_fail = 0;
                    }
                    else
                    {
                        dm_fail++;
                        if (dm_fail > stop_fails_send_dm)
                        {
                            tx_console.write_on_console("bot reached likes fails [ " + stop_fails_send_dm + " ] secure stop");
                            stop(true);
                            return;

                        }
                    }
                }                

                processing_accounts_list.RemoveAt(0);
                await wait(delay);
            }

            tx_console.write_on_console("bot ended");
            stop(true);
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
                tx_console.write_on_console("loaded: " + processing_accounts_list.Count.ToString() + " Accounts");

            }
        }

        public void save_on_file_accounts_not_proccessed()
        {


            if (processing_accounts_list.Count > 0)
            {


                bool exists = System.IO.Directory.Exists("SendDmBot");

                if (!exists)
                    System.IO.Directory.CreateDirectory("SendDmBot");

                using (StreamWriter scrivi = new StreamWriter("SendDmBot/left_send_dm.txt"))
                {
                    for (int i = 0; i < processing_accounts_list.Count(); i++)
                    {
                        scrivi.WriteLine(processing_accounts_list[i]);
                    }
                }

                tx_console.write_on_console("Accounts not processed saved in 'SendDmBot/left_send_dm.txt'");
            }
            else
            {
                bool exists = System.IO.Directory.Exists("SendDmBot");

                if (!exists)
                    System.IO.Directory.CreateDirectory("SendDmBot");

                using (StreamWriter scrivi = new StreamWriter("SendDmBot/left_send_dm.txt"))
                {
                    scrivi.WriteLine("");
                }

                tx_console.write_on_console("Accounts not processed saved in 'SendDmBot/left_send_dm.txt'");
            }

        }
    }
}

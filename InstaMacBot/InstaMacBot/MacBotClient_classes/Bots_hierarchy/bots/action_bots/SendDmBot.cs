using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMacBot.classes
{
    /// <summary>
    /// <para>this class represents a send dms bot that works on a list of username for each username on list sends a dm</para>
    /// <para>objects of this class are mutable</para>
    /// </summary>
    public class SendDmBot : SSSBot
    {
        /// <summary>
        /// number of dms sent
        /// </summary>
        private int dms;
        /// <summary>
        /// list of accounts unsername followed
        /// </summary>
        private List<string> processing_accounts_list;
        /// <summary>
        /// the user that bot is using the account to do all actions
        /// </summary>
        private UserApi UtenteApi;
        /// <summary>
        /// <para>limit of fails when bot is serching an account with the username</para>
        /// <para>the search could fail for some causes: account disables, account banned, ..., instagram blocked the bot chause it is doint too many actions</para>
        /// </summary>
        private int stop_fails_search_user;
        /// <summary>
        /// limit of fails when bot is sending a dm, maybe instagram blocked send dm action, so when the bot fails reach that value stops 
        /// </summary>
        private int stop_fails_send_dm;
        /// <summary>
        /// delay in seconds between each account in processing_accounts_list
        /// </summary>
        private int delay;
        /// <summary>
        /// the message that the bot will send at all accounts inside the processing_accounts_list
        /// </summary>
        private string message;
        /// <summary>
        /// a link sended in dm after the message (currently not avaible)
        /// </summary>
        private string link;
        /// <summary>
        /// a procedure (void function) called when finish or stopped (used to control element inside the form)
        /// </summary>
        private Action actions_bot_finshed;
        /// <summary>
        /// path where bot will save all files about this userApi: ./Accounts/username
        /// </summary>
        private string path_bot_save_info;

        /// <param name="Utente">the user that bot is using the account to do all actions</param>
        /// <param name="path_bot_save_info">path where bot will save all files about this userApi: ./Accounts/username</param>
        /// <param name="tx_console">the console where the bot will log its process</param>
        /// <param name="stop_fails_search_user">
        /// <para>limit of fails when bot is serching an account with the username</para>
        /// <para>the search could fail for some causes: account disables, account banned, ..., instagram blocked the bot chause it is doint too many actions</para>
        /// </param>
        /// <param name="message">limit of fails when bot is sending a dm, maybe instagram blocked send dm action, so when the bot fails reach that value stops </param>
        /// <param name="link">a link sended in dm after the message (currently not avaible)</param>
        /// <param name="stop_fails_send_dm">limit of fails when bot is sending a dm, maybe instagram blocked send dm action, so when the bot fails reach that value stops </param>
        /// <param name="delay">delay in seconds between each account in processing_accounts_list</param>
        /// <param name="actions">a procedure (void function) called when finish or stopped (used to control element inside the form)</param>
        public SendDmBot(UserApi Utente, string path_bot_save_info, BotConsole tx_console = null, int stop_fails_search_user = 20, string message = "", string link = "", int stop_fails_send_dm = 5, int delay = 40, Action actions = null) : base(tx_console)
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
        /// <summary>
        /// get the message that will be sent in dm at all accounts in processing_accounts_list
        /// </summary>
        /// <returns>the message that will be sent in dm</returns>
        public string get_message()
        {
            return message;
        }
        /// <summary>
        /// set a message that will be sent at all accounts in processing_accounts_list
        /// </summary>
        /// <param name="message">message that will set and used by the bot</param>
        public void set_message(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// set a link that will be sent after the message at all accounts in processing_accounts_list (currently not avaible)
        /// </summary>
        /// <param name="link">the link that will be set</param>
        public void set_link(string link)
        {
            this.link = link;
        }
        /// <summary>
        /// get a link that will be sent after the message at all accounts in processing_accounts_list (currently not avaible)
        /// </summary>
        /// <returns>the link that will be sent after the message</returns>
        public string get_link()
        {
            return link;
        }
        /// <summary>
        /// set the delay between each account inside processing_accounts_list
        /// </summary>
        /// <param name="i">seconds of delay i>=30</param>
        /// <returns>
        /// <para>true if the delay is setted</para>
        /// <para>false if the delay is not setted: i less than 30</para>
        /// </returns>
        public bool set_delay(int i)
        {
            if (i < 30)
                return false;

            delay = i;
            return true;

        }
        /// <summary>
        /// start the bot
        /// </summary>
        public override void start()
        {
            status = true;
            bot_procedure();
        }


        /// <summary>
        /// stop the bot
        /// </summary>
        /// <param name="save_infos">
        /// <para>if true bot will save all infos in files inside path_bot_save_info folder</para>
        /// <para>it saves the remaining accounts inside processing_accounts_list inside a files</para>
        /// </param>
        public override void stop(bool save_infos = false)
        {
            if (save_infos)
                save_on_file_accounts_not_proccessed_list_bot_file_saver(path_bot_save_info);

            status = false;
            actions_bot_finshed();
            console.write_on_console("bot ended");
        }

        /// <summary>
        /// sleeps the cpu for some seconds
        /// </summary>
        /// <param name="seconds">number of seconds of sleep</param>
        /// <returns>true when delay finishes</returns>
        private async Task<bool> wait(int seconds)
        {
            int i = 0;
            while (i < seconds && status)
            {
                await Task.Delay(1000);
                i++;
            }
            return true;
        }
        /// <summary>
        /// clear the processing_accounts_list
        /// </summary>
        public void clear_processing_accounts_list()
        {
            processing_accounts_list.Clear();
            console.write_on_console("processing account list cleared");
        }

        /// <summary>
        /// the bot procedure, all bot actions are done here
        /// </summary>
        private async void bot_procedure()
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


                bool dm_sent = await UtenteApi.send_dm_text(message, processing_accounts_list[0]);


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

        /// <summary>
        /// load usernames inside processing_accounts_list from a txt using an open file dialog (one username on each line)
        /// </summary>
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

        /// <summary>
        /// load usernames inside processing_accounts_list from a txt (one username on each line)
        /// </summary>
        /// <param name="path">path of the txt file where are written all usernames where the bot will operate leaving likes and follows</param>
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

        /// <summary>
        /// save on file all accounts not processed by the bot, the remining accounts inside the processing_accounts_list
        /// </summary>
        /// <param name="path_account">
        /// <para>path where are saved all bots files of the user logged in the bot (userapi)</para>
        /// <para>tipically: ./Accounts/username/left DM accounts (send dm bot).txt</para>
        /// </param>
        public void save_on_file_accounts_not_proccessed_list_bot_file_saver(string path_account)
        {
            BotFileSaver save_file = new DesktopBotFileSaver(path_account + "/left DM accounts (send dm bot).txt", true);
            save_file.write_list_on_file(processing_accounts_list);
            console.write_on_console("Accounts not processed saved in the list: left DM accounts (send dm bot)");

        }

    }
}

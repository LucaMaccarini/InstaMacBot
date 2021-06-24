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
    /// this class represents an unfollow bot that works on a list of username and it unfollows all users on the list
    ///  objects of this class are mutable
    /// </summary>
    public class UnfollowBot : SSSBot
    {
        /// <summary>
        /// number of unfollow done by the bot
        /// </summary>
        private int unfollow;
        /// <summary>
        /// list of usernames of target accounts that will be unfollowed
        /// </summary>
        private List<string> followed_list;
        /// <summary>
        /// list of usernames of accounts that the bot had got problems trying to unfollow
        /// </summary>
        private List<string> error_unfollowed_list;
        /// <summary>
        /// the user that bot is using the account to do all actions
        /// </summary>
        private UserApi UtenteApi;
        /// <summary>
        /// <para>limit of fails when bot is serching an account with the username, so when the bot fails reach that value stops.</para>
        /// <para>The search could fail for some causes: account disables, account banned, ..., instagram blocked the bot chause it is doint too many actions</para>
        /// </summary>
        private int stop_fails_search_user;
        /// <summary>
        /// <para>limit of fails when bot is unfollowing an account with the username, so when the bot unfollow fails reach the that value stops.</para>
        /// <para>The search could fail for some causes: account disables, account banned, ..., instagram blocked the bot chause it is doint too many actions</para>
        /// </summary>
        private int stop_fails_unfollow;
        /// <summary>
        /// delay in seconds between each account in processing_accounts_list
        /// </summary>
        private int delay;
        /// <summary>
        /// the path of the input txt that contains all accounts to unfollow, i save thi path cause when bot finishes or someone stops it; the bot will remove the unfollowed accounts froma the source file
        /// </summary>
        private string file_followed_accounts_path;
        /// <summary>
        /// a procedure (void function) called when finish or stopped (used to control element inside the form)
        /// </summary>
        private Action actions_bot_finshed;
        /// <summary>
        /// path where bot will save all files about this userApi: ./Accounts/username
        /// </summary>
        private string path_bot_save_info;
        /// <summary>
        /// a set that contains all usernames that UtenteApi is following
        /// </summary>
        HashSet<string> following;


        /// <param name="Utente">the UserApi object that rappresents the bot logged user (the account that will unfollow the target accounts)</param>
        /// <param name="path_bot_save_info">path where bot will save all files about this userApi: ./Accounts/username</param>
        /// <param name="tx_console">the console where the bot will log its process</param>
        /// <param name="stop_fails_search_user">
        /// <para>limit of fails when bot is serching an account with the username</para>
        /// <para>the search could fail for some causes: account disables, account banned, ..., instagram blocked the bot chause it is doint too many actions</para>
        /// </param>
        /// <param name="stop_fails_unfollow">
        /// <para>limit of fails when bot is unfollowing an account with the username, so when the bot unfollow fails reach the that value stops.</para>
        /// <para>The search could fail for some causes: account disables, account banned, ..., instagram blocked the bot chause it is doint too many actions</para>
        /// </param>
        /// <param name="delay">delay in seconds between each account in processing_accounts_list</param>
        /// <param name="actions">a procedure (void function) called when finish or stopped (used to control element inside the form)</param>
        public UnfollowBot(UserApi Utente, string path_bot_save_info, BotConsole tx_console = null, int stop_fails_search_user = 20, int stop_fails_unfollow = 5, int delay = 50, Action actions = null) : base(tx_console)
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
            actions_bot_finshed = actions;
            this.path_bot_save_info = path_bot_save_info;
        }

        /// <summary>
        /// get the number of unfollow actions done by the bot
        /// </summary>
        /// <returns>number of unfollow done by the bot</returns>
        public int get_unfollow { get { return unfollow; } }

        /// <summary>
        /// set the delay between each account inside processing_accounts_list
        /// </summary>
        /// <param name="i">seconds of delay i>=40 </param>
        /// <returns>
        /// <para>true if the delay is setted</para>
        /// <para>false if the delay is not setted: i less than 40</para>
        /// </returns>
        public bool set_delay(int i)
        {
            if (i < 40)
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
        /// <para>it saves the remaining accounts inside followed_list and error_unfollowed_list inside 2 different files</para>
        /// </param>
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

        /// <summary>
        /// sleeps the cpu for some seconds
        /// </summary>
        /// <param name="seconds">number of seconds of sleep</param>
        /// <returns>true when delay finishes</returns>
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

        /// <summary>
        /// the bot procedure, all bot actions are done here
        /// </summary>
        private async void bot_procedure()
        {
            if (followed_list.Count == 0)
            {
                console.write_on_console("no accounts followed loaded");
                stop(false);

                return;
            }

            following = await UtenteApi.get_following();

            error_unfollowed_list.Clear();
            unfollow = 0;
            int fails_search_user = 0;

            while (followed_list.Count > 0 && status)
            {

                IResult<InstaUserInfo> utente;
                bool error;
                do
                {
                    error = false;
                    utente = await UtenteApi.get_user_info(followed_list[0]);

                    if (utente.Value == null)
                    {
                        console.write_on_console("account not found skipped: " + followed_list[0]);
                        error = true;

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

                } while (error && followed_list.Count > 0);



                if (followed_list.Count == 0)
                {
                    stop(true);
                    return;
                }

                //user extracted
                bool do_wait = false;
                if (following.Contains(utente.Value.Username))
                {
                    do_wait = true;
                    bool esito = await UtenteApi.unfollow(utente.Value.Pk);


                    if (esito)
                    {

                        unfollow++;

                        console.write_on_console("unfollowed: " + followed_list[0] + " [tot: " + unfollow + "]");
                    }
                    else
                    {
                        error_unfollowed_list.Add(followed_list[0]);
                        console.write_on_console("unfollow error: " + followed_list[0]);
                    }
                }
                followed_list.RemoveAt(0);
                if(do_wait)
                    await wait(delay);
            }



            if (status)
                stop(true);
        }

        /// <summary>
        /// load usernames inside followed_list from a txt using an open file dialog (one username on each line)
        /// </summary>
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

        /// <summary>
        /// load usernames inside followed_list from a txt (one username on each line)
        /// </summary>
        /// <param name="path">path of the txt file where are written all usernames where the bot will operate leaving likes and follows</param>
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

        /// <summary>
        /// clear the followed_list: delete all usernames stored in it
        /// </summary>
        public void clear_followed_list()
        {
            followed_list.Clear();
            console.write_on_console("followed list cleared");
        }

        /// <summary>
        /// save on file all accounts not processed by the bot, the remining accounts inside the followed_list:
        /// <para>1) the procedure try to remove the unfollowed accounts frome the source file loaded with the load_followed_accounts method</para>
        /// <para>2) if the source file doesen't exist cause someone deleted it; this procedure saves the infos inside account directory (account_path) inside the file 'left to unfollow (unfollowed bot).txt'</para>
        /// </summary>
        /// <param name="account_path">
        /// <para>path where are saved all bots files of the user logged in the bot (userapi)</para>
        /// <para>tipically: ./Accounts/username/left accounts (follow like bot).txt</para>
        /// </param>
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
                console.write_on_console("Removed the unfollowed accounts from the source list: " + path_splitted[path_splitted.Length - 1].Split('.')[0]);
            }

        }




        /// <summary>
        /// save on file all accounts processed where the unfollow actions had problems (unfollow action not done, needs a human check)
        /// </summary>
        /// <param name="account_path">
        /// <para>path where are saved all bots files of the user logged in the bot (userapi)</para>
        /// <para>tipically: ./Accounts/username/left accounts (follow like bot).txt</para>
        /// </param>
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

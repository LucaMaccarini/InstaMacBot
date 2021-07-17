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
    /// this class represents a follow, like lasts pics bot that works with a list of username
    /// for each username on list: follow and like lasts pics
    /// objects of this class are mutable
    /// </summary>
    public class FollowLikeLastsPicBot : SSSBot
    {
        /// <summary>
        /// number of likes and follow actions done by the bot
        /// </summary>
        private int likes, follow;
        /// <summary>
        /// list of usernames of target accounts where bot will leave likes and follow
        /// </summary>
        private List<string> processing_accounts_list;
        /// <summary>
        /// list of accounts unsername followed
        /// </summary>
        private List<string> followed_list;
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
        /// numbers of recent post liked on each account inside processing_accounts_list
        /// </summary>
        private int like_lasts_pic;
        /// <summary>
        /// limit of fails when bot is likeing a post, maybe instagram blocked like action, so when the bot fails reach that value stops
        /// </summary>
        private int stop_fails_like;
        /// <summary>
        /// limit of fails when bot is following a post, maybe instagram blocked follow action, so when the bot fails reach that value stops
        /// </summary>
        private int stop_fails_follow;
        /// <summary>
        /// delay in seconds between each account in processing_accounts_list
        /// </summary>
        private int delay;
        /// <summary>
        /// if is true bot will not follow users inside processing_accounts_list
        /// </summary>
        private bool follow_account;
        /// <summary>
        /// a procedure (void function) called when finish or stopped (used to control element inside the form)
        /// </summary>
        private Action actions_bot_finshed;
        /// <summary>
        /// path where bot will save all files about this userApi: ./Accounts/username
        /// </summary>
        private string path_bot_save_info;

        /// <summary>
        /// get the number of accounts where the bot will work leaving likes and follow
        /// </summary>
        /// <returns>the number of accounts inside processing_accounts_list</returns>
        public int get_account_pocessing_counts { get { return processing_accounts_list.Count; } }

        /// <summary>
        /// fet the number of likes that the bot left
        /// </summary>
        /// <returns>the number of likes leaved by the bot</returns>
        public int get_likes { get { return likes; } }

        /// <summary>
        /// fet the number of follow that the bot left
        /// </summary>
        public int get_follow { get { return follow; } }

        /// <param name="Utente">the UserApi object that rappresents the bot logged user (the account that will leave likes and follow)</param>
        /// <param name="path_bot_save_info">path where bot will save all files about this userApi: ./Accounts/username</param>
        /// <param name="tx_console">the console where the bot will log its process</param>
        /// <param name="stop_fails_search_user">
        /// <para>limit of fails when bot is serching an account with the username</para>
        /// <para>the search could fail for some causes: account disables, account banned, ..., instagram blocked the bot chause it is doint too many actions</para>
        /// </param>
        /// <param name="like_lasts_pic">numbers of recent post liked on each account inside processing_accounts_list</param>
        /// <param name="follow_accounts">if is true bot will not follow users inside processing_accounts_list</param>
        /// <param name="stop_fails_like">limit of fails when bot is likeing a post, maybe instagram blocked like action</param>
        /// <param name="stop_fails_follow">limit of fails when bot is following a post, maybe instagram blocked follow action</param>
        /// <param name="delay">delay in seconds between each account in processing_accounts_list</param>
        /// <param name="actions">a procedure (void function) called when finish or stopped (used to control element inside the form)</param>
        public FollowLikeLastsPicBot(UserApi Utente, string path_bot_save_info, BotConsole tx_console = null, int stop_fails_search_user = 10, int like_lasts_pic = 1, bool follow_accounts = true, int stop_fails_like = 5, int stop_fails_follow = 5, int delay = 50, Action actions = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente must be != null");
            if (like_lasts_pic > 3 || like_lasts_pic <= 0) throw new ArgumentOutOfRangeException("like_lasts_pic must be > 0 and <= 3");
            if (stop_fails_search_user <= 0) throw new ArgumentOutOfRangeException("stop_fails_search_user must be > 0");
            if (stop_fails_like <= 0) throw new ArgumentOutOfRangeException("stop_fails_like must be > 0");
            if (stop_fails_follow <= 0) throw new ArgumentOutOfRangeException("stop_fails_follow must be > 0");
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
            this.follow_account = follow_accounts;
            actions_bot_finshed = actions;
            this.path_bot_save_info = path_bot_save_info;


        }

        /// <summary>
        /// set how many recent posts the bot will leave like on each account inside processing_accounts_list
        /// </summary>
        /// <param name="i">
        /// <para>true if the bot setted the new value of like_lasts_pic</para>
        /// <para>false if the bot didn't cange the value of like_lasts_pic</para>
        /// </param>
        /// <returns></returns>
        public bool set_likes_last_pic(int i)
        {
            if (i < 0 || i > 3)
                return false;

            like_lasts_pic = i;
            return true;

        }

        /// <summary>
        /// set if bot will follow or no the users inside processing_accounts_list
        /// </summary>
        /// <param name="i">
        /// <para>if true bot will follow</para>
        /// <para>else bot will not follow the accounts</para>
        /// </param>
        public void set_follow_accounts(bool i)
        {
            follow_account = i;
        }

        /// <summary>
        /// set the delay between each account inside processing_accounts_list
        /// </summary>
        /// <param name="i">seconds of delay i>=30 </param>
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
        /// <para>it saves the remaining accounts inside processing_accounts_list and followed_list inside 2 different files</para>
        /// </param>
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

        /// <summary>
        /// get a list of lasts media posted by the user with the username passeed in the username parameter
        /// </summary>
        /// <param name="username">username of the account were are extracted lasts media (post extracted at least 3)</param>
        /// <returns>a list of last account media where bot will left likes</returns>
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

        /// <summary>
        /// sleeps the cpu for some seconds
        /// </summary>
        /// <param name="seconds">number of seconds of sleep</param>
        /// <returns>true when delay finishes</returns>
        private async Task<bool> wait(int seconds)
        {
            int i = 0;
            while (i < seconds*2 && status)
            {
                await Task.Delay(500);
                i++;
            }
            return true;
        }


        /// <summary>
        /// the bot procedure, all bot actions are done here
        /// </summary>
        private async void bot_procedure()
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
          

            while (processing_accounts_list.Count > 0 && status)
            {
                bool private_account;
                do
                {
                    IResult<InstaUser> working_account = await UtenteApi.get_user(processing_accounts_list[0]);

                    if (working_account.Value != null)
                    {
                        if (search_fail != 0)
                        {
                            search_fail = 0;
                        }

                        private_account = working_account.Value.IsPrivate;

                        if (private_account)
                        {
                            console.write_on_console("private account skipped: " + processing_accounts_list[0]);
                            processing_accounts_list.RemoveAt(0);
                        }
                    }
                    else
                    {
                        console.write_on_console("account not found skipped: " + processing_accounts_list[0] + " [search fail = " + search_fail + "]");

                        private_account = true; //usato per skippare ma l'account non è stato proprio trovato
                        processing_accounts_list.RemoveAt(0);

                        search_fail++;
                        if (search_fail > stop_fails_search_user)
                        {
                            //MessageBox.Show("errore sugli ultimi 20 account: stop di sicurezza");
                            console.write_on_console("stop fails reach [ " + stop_fails_search_user + " ], securestop");
                            stop(true);
                            return;

                        }
                    }
                } while (private_account && status);

                if (!status)
                {
                    stop(true);
                    return;
                }

                //user exist and isn't private
               
                InstaMediaList foto = null;

                foto = await lasts_media_id(processing_accounts_list[0]);
                if (foto == null)
                {
                    console.write_on_console("no photo account skipped: " + processing_accounts_list[0]);
                    processing_accounts_list.RemoveAt(0);
                    continue;
                }

                //lasts posts extracted

                int i = 0;
                while (i < like_lasts_pic && i < foto.Count)
                {
                    bool like_messo = await UtenteApi.put_like(foto[i].InstaIdentifier);


                    if (like_messo)
                    {
                        likes++;
                        int k = i + 1;
                        console.write_on_console("like last " + k + " foto of: " + processing_accounts_list[0] + " [tot likes: " + likes + "]");
                        if (like_fail != 0)
                        {
                            like_fail = 0;
                        }
                        else
                        {
                            like_fail++;
                            if (like_fail > stop_fails_like)
                            {
                                console.write_on_console("bot reached likes fails [ " + stop_fails_like + " ] secure stop");
                                stop(true);
                                return;

                            }
                        }
                    }
                    i++;
                }

                if (follow_account)
                {
                    //follow the user

                    bool follow_messo = await UtenteApi.follow(processing_accounts_list[0]);

                    if (follow_messo)
                    {
                        followed_list.Add(processing_accounts_list[0]);
                        follow++;
                        console.write_on_console("followed: " + processing_accounts_list[0] + " [tot follow: " + follow + "]");
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


        /// <summary>
        /// clear the processing_accounts_list
        /// </summary>
        public void clear_processing_accounts_list()
        {
            processing_accounts_list.Clear();
            console.write_on_console("processing account list cleared");
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

        /// <summary>
        /// save on file all accounts not processed by the bot, the remining accounts inside the processing_accounts_list
        /// </summary>
        /// <param name="path_account">
        /// <para>path where are saved all bots files of the user logged in the bot (userapi)</para>
        /// <para>tipically: ./Accounts/username/left accounts (follow like bot).txt</para>
        /// </param>
        public void save_on_file_accounts_not_proccessed_list_bot_file_saver(string path_account)
        {
            BotFileSaver save_file = new DesktopBotFileSaver(path_account + "/left accounts (follow like bot).txt", true);
            save_file.write_list_on_file(processing_accounts_list);
            console.write_on_console("Accounts not processed saved in the list: left accounts (follow like bot)");

        }

        /// <summary>
        /// save on file all accounts followed by the bot
        /// </summary>
        /// <param name="path_account">
        /// <para>path where are saved all bots files of the user logged in the bot (userapi)</para>
        /// <para>tipically ./Accounts/username/followed (follow like bot).txt</para>
        /// </param>
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

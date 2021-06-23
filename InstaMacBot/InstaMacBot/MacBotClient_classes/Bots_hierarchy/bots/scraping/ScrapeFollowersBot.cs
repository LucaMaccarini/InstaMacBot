using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InstaMacBot.classes
{
    /// <summary>
    /// <para>this class represents a screaper bot that extract all accounts that are following a target account (limit about 20.000 accounts)</para>
    /// <para>objects of this class are mutable</para>
    /// <para>scraped accounts limit to about 20k of accounts for safety</para>
    /// </summary>
    public class ScrapeFollowersBot : SSSBot
    {
        /// <summary>
        /// target account where the bot will scrape the followers accounts username
        /// </summary>
        private string username;
        /// <summary>
        /// the list of scraped usernames
        /// </summary>
        private List<string> extracted_list;
        /// <summary>
        /// the user that bot is using the account to do all actions (in this bot is used to navigate inside the target account's followers)
        /// </summary>
        private UserApi UtenteApi;


        /// <param name="Utente">the user that bot is using the account to do all actions (in this bot is used to navigate inside the target account's followers)</param>
        /// <param name="tx_console">the console where the bot will log its process</param>
        public ScrapeFollowersBot(UserApi Utente, BotConsole tx_console = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente needs to be != null");

            UtenteApi = Utente;
            extracted_list = new List<string>();
            status = false;
        }


        /// <param name="Utente">the user that bot is using the account to do all actions (in this bot is used to navigate inside the target account's followers)</param>
        /// <param name="username">the username of the target account</param>
        /// <param name="tx_console">the console where the bot will log its process</param>
        public ScrapeFollowersBot(UserApi Utente, string username, BotConsole tx_console = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente must be != null");
            if (username != "") throw new ArgumentNullException("username must be != ''");

            UtenteApi = Utente;
            extracted_list = new List<string>();
            status = false;
            this.username = username;
        }

        /// <summary>
        /// set the target account by the username
        /// </summary>
        /// <param name="username"></param>
        public void set_username(string username)
        {
            this.username = username;
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
        /// stop the bot: but this bot isn't stopable cause iss not possible stop the scraping routine (to make the hiierarchy easy scraping bots are son of sssbot and startStopBot but really isn't possible stop it)
        /// </summary>
        /// <param name="save_infos">not important his value cause this method is unless</param>
        public override void stop(bool save_infos = false)
        {
            MessageBox.Show("non stoppable bot");
        }

        /// <summary>
        /// the bot procedure, all bot actions are done here
        /// </summary>
        private async void bot_procedure()
        {
            extracted_list.Clear();

            console.write_on_console("Extracting followers, don't close bot");

            IResult<InstaUserShortList> followers = await UtenteApi.get_user_followers(username);

            if (followers.Value != null)
            {

                for (int i = 0; i < followers.Value.Count; i++)
                {
                    extracted_list.Add(followers.Value[i].UserName);
                }
                console.write_on_console("Extracted Followers: " + extracted_list.Count.ToString() + " (instragram limit reached)");

            }
            else
            {
                console.write_on_console("Account private or not exist");
            }

            status = false;


        }

        /// <summary>
        /// clear the extracted_list: list of scraped usernames
        /// </summary>
        public void clear_extracted_list()
        {
            extracted_list.Clear();
            console.write_on_console("extracted list cleared");
        }

        /// <summary>
        /// save in a file the extracted_list on a file (one username each line)
        /// </summary>
        /// <param name="path_file_extension">path where save the extracted_list</param>
        public void save_on_file_extracted_list_bot_file_saver(string path_file_extension)
        {
            if (extracted_list.Count > 0)
            {
                console.write_on_console("saving on file...");

                BotFileSaver save_file = new DesktopBotFileSaver(path_file_extension, true);

                save_file.write_list_on_file(extracted_list);
                string[] split_path = path_file_extension.Split('/');
                console.write_on_console("Scraped accounts saved in the list: " + split_path[split_path.Length - 1].Split('.')[0]);

            }
        }
    }
}

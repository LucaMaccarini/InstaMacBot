using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstaMacBot.MacBotClient_classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMacBot.classi_MacBotClient
{
    class ExtractFollowersBot : SSSBot
    {
        //OVERVIEW: this class represents a followers screaper bot that extract all followers it can from a username
        //          objects of this class are mutable

        private string username;
        private List<string> extracted_list;
        private bool stop_bot;
        private UserApi UtenteApi;

        public ExtractFollowersBot(UserApi Utente, BotConsole tx_console = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente needs to be != null");

            UtenteApi = Utente;
            extracted_list = new List<string>();
            stop_bot = true;
            status = false;
        }

        public ExtractFollowersBot(UserApi Utente, string username, BotConsole tx_console = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente must be != null");
            if (username != "") throw new ArgumentNullException("username must be != ''");

            UtenteApi = Utente;
            extracted_list = new List<string>();
            stop_bot = true;
            status = false;
            this.username = username;
        }

        public void set_username(string username)
        {
            this.username = username;
        }
        public override void start()
        {
            stop_bot = false;
            status = true;
            procedura_bot();
        }

        public override  void stop(bool save_infos)
        {
            MessageBox.Show("non stoppable bot");
        }


        private async void procedura_bot()
        {
            extracted_list.Clear();

            IResult<InstaUserShortList> followers = await UtenteApi.get_user_followers(username);


            for (int i = 0; i < followers.Value.Count; i++)
            {
                extracted_list.Add(followers.Value[i].UserName);
            }
            tx_console.write_on_console("Extracted Followers: " + extracted_list.Count.ToString());

        }

        public void clear_extracted_list()
        {
            extracted_list.Clear();
            tx_console.write_on_console("extracted list cleared");
        }

        public void save_on_file_extracted_list()
        {
            if (extracted_list.Count > 0)
            {

                bool exists = System.IO.Directory.Exists("ExtractFollowersBot");

                if (!exists)
                    System.IO.Directory.CreateDirectory("ExtractFollowersBot");

                using (StreamWriter scrivi = File.AppendText("ExtractFollowersBot/Extracted_followers.txt"))
                {
                    for (int i = 0; i < extracted_list.Count(); i++)
                    {
                        scrivi.WriteLine(extracted_list[i]);
                    }
                }

                tx_console.write_on_console("extracted Accounts saved in 'ExtractFollowersBot/Extracted_followers.txt'");

            }
        }
    }
}

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
    class ScrapeFollowersBot : SSSBot
    {
        //OVERVIEW: this class represents a followers screaper bot that extract all followers it can from a username
        //          objects of this class are mutable

        private string username;
        private List<string> extracted_list;
        private UserApi UtenteApi;

        public ScrapeFollowersBot(UserApi Utente, BotConsole tx_console = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente needs to be != null");

            UtenteApi = Utente;
            extracted_list = new List<string>();
            status = false;
        }

        public ScrapeFollowersBot(UserApi Utente, string username, BotConsole tx_console = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente must be != null");
            if (username != "") throw new ArgumentNullException("username must be != ''");

            UtenteApi = Utente;
            extracted_list = new List<string>();
            status = false;
            this.username = username;
        }

        public void set_username(string username)
        {
            this.username = username;
        }
        public override void start()
        {
            status = true;
            procedura_bot();
        }

        public override  void stop(bool save_infos=false)
        {
            MessageBox.Show("non stoppable bot");
        }


        private async void procedura_bot()
        {
            extracted_list.Clear();

            console.write_on_console("Extracting followers, don't close bot");

            IResult<InstaUserShortList> followers = await UtenteApi.get_user_followers(username);

            if (followers.Value!=null)
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

        public void clear_extracted_list()
        {
            extracted_list.Clear();
            console.write_on_console("extracted list cleared");
        }

        public void save_on_file_extracted_list_bot_file_saver(string path_file_extension)
        {
            if (extracted_list.Count > 0)
            {
                console.write_on_console("saving on file...");

                BotFileSaver save_file = new DesktopBotFileSaver(path_file_extension, true);
                
                save_file.write_list_on_file(extracted_list);
                string[] split_path = path_file_extension.Split('/');
                console.write_on_console("Scraped accounts saved in the list: " + split_path[split_path.Length-1].Split('.')[0]);

            }
        }
    }
}

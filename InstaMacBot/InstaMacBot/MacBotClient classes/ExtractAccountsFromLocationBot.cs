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
    class ExtractAccountsFromLocationBot : SSSBot
    {
        //OVERVIEW: this class represents a followers screaper bot that extract all followers it can from Locations
        //          objects of this class are mutable

        private string location;
        private List<string> extracted_list;
        private bool stop_bot;
        private UserApi UtenteApi;

        public ExtractAccountsFromLocationBot(UserApi Utente, BotConsole tx_console = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente needs to be != null");

            UtenteApi = Utente;
            extracted_list = new List<string>();
            stop_bot = true;
            status = false;
        }

        public ExtractAccountsFromLocationBot(UserApi Utente, string location, BotConsole tx_console = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente must be != null");
            if (location != "") throw new ArgumentNullException("username must be != ''");

            UtenteApi = Utente;
            extracted_list = new List<string>();
            stop_bot = true;
            status = false;
            this.location = location;
        }

        public void set_location(string location)
        {
            this.location = location;
        }
        public override void start()
        {
            stop_bot = false;
            status = true;
            procedura_bot();
        }

        public override void stop(bool save_infos)
        {
            MessageBox.Show("non stoppable bot");
        }


        private async void procedura_bot()
        {
            extracted_list.Clear();

            tx_console.write_on_console("Extracting followers, don't close bot");
            HashSet<string> followers = await UtenteApi.get_user_from_location(location);
            if(followers == null)
            {
                tx_console.write_on_console("Location not found");
                return;
            }

            if (followers.Count == 0)
            {
                tx_console.write_on_console("can't find that location posts");

            }
            else
            {
                foreach (string entry in followers)
                {
                    extracted_list.Add(entry);
                }

                tx_console.write_on_console("extracted: " + extracted_list.Count + " Accounts");
            }

            status = false;


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

                bool exists = System.IO.Directory.Exists("ExtractAccountsFromLocationBot");

                if (!exists)
                    System.IO.Directory.CreateDirectory("ExtractAccountsFromLocationBot");

                using (StreamWriter scrivi = new StreamWriter("ExtractAccountsFromLocationBot/Extracted_followers_from_location.txt"))
                {
                    for (int i = 0; i < extracted_list.Count(); i++)
                    {
                        scrivi.WriteLine(extracted_list[i]);
                    }
                }

                tx_console.write_on_console("extracted Accounts saved in 'ExtractAccountsFromLocationBot/Extracted_followers_from_location.txt'");

            }
        }
    }
}

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
    class ExtractAccountsFromHastagBot : SSSBot
    {
        //OVERVIEW: this class represents a followers screaper bot that extract all followers it can from hastag
        //          objects of this class are mutable

        private string hastag;
        private List<string> extracted_list;
        private UserApi UtenteApi;

        public ExtractAccountsFromHastagBot(UserApi Utente, BotConsole tx_console = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente needs to be != null");

            UtenteApi = Utente;
            extracted_list = new List<string>();
            status = false;
        }

        public ExtractAccountsFromHastagBot(UserApi Utente, string hastag, BotConsole tx_console = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente must be != null");
            if (hastag != "") throw new ArgumentNullException("username must be != ''");

            UtenteApi = Utente;
            extracted_list = new List<string>();
            status = false;
            this.hastag = hastag;
        }

        public void set_hastag(string hastag)
        {
            this.hastag = hastag;
        }
        public override void start()
        {
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
            HashSet<string> followers = await UtenteApi.get_user_from_hastag(hastag);

            if (followers.Count==0)
            {
                tx_console.write_on_console("can't find that hastag posts");

            }
            else
            {
                foreach(string entry in followers)
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

                bool exists = System.IO.Directory.Exists("ExtractAccountsFromHastagBot");

                if (!exists)
                    System.IO.Directory.CreateDirectory("ExtractAccountsFromHastagBot");

                using (StreamWriter scrivi = new StreamWriter("ExtractAccountsFromHastagBot/Extracted_followers_from_hastag.txt"))
                {
                    for (int i = 0; i < extracted_list.Count(); i++)
                    {
                        scrivi.WriteLine(extracted_list[i]);
                    }
                }

                tx_console.write_on_console("extracted Accounts saved in 'ExtractAccountsFromHastagBot/Extracted_followers_from_hastag.txt'");

            }
        }

    }
}

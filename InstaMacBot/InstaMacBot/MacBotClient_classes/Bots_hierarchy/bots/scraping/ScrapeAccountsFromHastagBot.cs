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
    class ScrapeAccountsFromHastagBot : SSSBot
    {
        //OVERVIEW: this class represents a followers screaper bot that extract all followers it can from hastag
        //          objects of this class are mutable

        private string hastag;
        private List<string> extracted_list;
        private UserApi UtenteApi;

        public ScrapeAccountsFromHastagBot(UserApi Utente, BotConsole tx_console = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente needs to be != null");

            UtenteApi = Utente;
            extracted_list = new List<string>();
            status = false;
        }

        public ScrapeAccountsFromHastagBot(UserApi Utente, string hastag, BotConsole tx_console = null) : base(tx_console)
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

        public override void stop(bool save_infos=false)
        {
            MessageBox.Show("non stoppable bot");
        }


        private async void procedura_bot()
        {
            extracted_list.Clear();

            console.write_on_console("Extracting followers, don't close bot");
            HashSet<string> followers = await UtenteApi.get_user_from_hastag(hastag);

            if (followers.Count==0)
            {
                console.write_on_console("can't find that hastag posts");

            }
            else
            {
                foreach(string entry in followers)
                {
                    extracted_list.Add(entry);
                }

                console.write_on_console("extracted: " + extracted_list.Count + " Accounts");
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
                console.write_on_console("Scraped Accounts saved in the list:" + split_path[split_path.Length - 1].Split('.')[0]);

            }
        }

    }
}

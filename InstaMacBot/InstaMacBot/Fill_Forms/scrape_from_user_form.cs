﻿using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstaMacBot.classes;

namespace InstaMacBot.DesktopInterface
{
    public partial class scrape_from_user_form : Form
    {
        //instagram user of Bot_client form 
        UserApi utente;

        //bot manager of main form
        BotClient bot_manager;

        //this bot
        private SSSBot extract_from_user;

        //console of bot
        private BotConsole console;

        //direcory where save bots files
        private string path_bots_file;


        public scrape_from_user_form(UserApi _utente, BotClient _bot_manager, string _path_bots_file)
        {
            InitializeComponent();
            utente = _utente;
            bot_manager = _bot_manager;
            path_bots_file = _path_bots_file;
        }

        private void scrape_from_user_form_Load(object sender, EventArgs e)
        {
            SetDoubleBuffered(tabControl1);
            SetDoubleBuffered(pn_description);
            SetDoubleBuffered(pn_options);
            SetDoubleBuffered(pn_controls);
            SetDoubleBuffered(pn_controls_status);
            SetDoubleBuffered(pn_console);


            console = new DesktopTextBoxConsole(tx_console);
            extract_from_user = new ScrapeFollowersBot(utente, tx_console: console);
            bot_manager.bots.Add("extract_from_user", extract_from_user);
        }

        //reduce containers flickering
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private async Task<bool> wait(int seconds)
        {
            int i = 0;
            while (i < seconds * 2 && extract_from_user.is_running)
            {
                await Task.Delay(500);
                i++;
            }
            return true;
        }

        private async void bt_start_scrape_followers_Click(object sender, EventArgs e)
        {
            bt_start_scrape_followers.Enabled = false;
            tabControl1.Controls["option_tab"].Enabled = false;
            pn_status.BackColor = Color.FromArgb(42, 150, 72);


            ScrapeFollowersBot x = (ScrapeFollowersBot)extract_from_user;
            if (!x.is_running)
            {
                x.set_username(tx_username.Text);
                console.write_on_console("extract process can take some times (more followers more time)");
                x.start();

                do
                {
                    console.write_on_console("wait extracting...");
                    await wait(10);

                } while (x.is_running);



            }


            x.save_on_file_extracted_list_bot_file_saver(path_bots_file + "/Scraped accounts from followers.txt");

            pn_status.BackColor = Color.FromArgb(196, 45, 45);
            tabControl1.Controls["option_tab"].Enabled = true;
            bt_start_scrape_followers.Enabled = true;


        }

        private void pn_description_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_description_Resize(object sender, EventArgs e)
        {
            lb_description.MaximumSize = pn_description.Size;
        }
    }
}

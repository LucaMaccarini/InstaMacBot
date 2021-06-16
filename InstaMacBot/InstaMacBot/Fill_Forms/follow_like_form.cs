using InstaMacBot.InstaMacBot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMacBot
{
    partial class follow_like_form : Form
    {
        //instagram user of Bot_client form 
        UserApi utente;

        //bot manager of main form
        BotClient bot_manager;

        //this bot
        SSSBot follow_like_bot;

        //console of bot
        BotConsole console;

        //direcory where save bots files
        private string path_bots_file;

        //list of all files of all bots
        bot_file_list files;


        public follow_like_form(UserApi _utente, BotClient _bot_manager, bot_file_list files)
        {
            InitializeComponent();
            utente = _utente;
            bot_manager = _bot_manager;
            path_bots_file = files.get_path();

            this.files = files;
            listBox_files.DataSource = this.files.files_list;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void follow_like_form_Load(object sender, EventArgs e)
        {
            SetDoubleBuffered(tabControl1);
            SetDoubleBuffered(pn_description);
            SetDoubleBuffered(pn_options);
            SetDoubleBuffered(pn_controls);
            SetDoubleBuffered(pn_controls_status);
            SetDoubleBuffered(pn_console);

            console = new DesktopTextBoxConsole(tx_console);

           

            follow_like_bot = new FollowLikeLastsPicBot(utente, path_bots_file, tx_console: console, actions:actions_bot_ended);
            bot_manager.bots.Add("follow_like", follow_like_bot);
        }

        //delegate bot object to set status to stop and enable start button when it finisced
        private void actions_bot_ended()
        {
            pn_status.BackColor = Color.FromArgb(196, 45, 45);
            bt_start_follow_like_bot.Enabled = true;
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

        private void bt_start_follow_like_bot_Click(object sender, EventArgs e)
        {
            if (listBox_files.SelectedIndex < 0)
            {
                console.write_on_console("no source list selected");
                return;
            }

            ((FollowLikeLastsPicBot)follow_like_bot).load_list_from_file(((bot_file_entry_list)listBox_files.Items[listBox_files.SelectedIndex]).get_path());
            bt_start_follow_like_bot.Enabled = false;
            pn_status.BackColor = Color.FromArgb(42, 150, 72);

            follow_like_bot.start();


        }

        private void cb_nlikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FollowLikeLastsPicBot x = (FollowLikeLastsPicBot)follow_like_bot;
            x.set_likes_last_pic(int.Parse(cb_nlikes.SelectedItem.ToString()));
        }

        private void cb_delay_SelectedIndexChanged(object sender, EventArgs e)
        {
            FollowLikeLastsPicBot x = (FollowLikeLastsPicBot)follow_like_bot;
            x.set_delay(int.Parse(cb_delay.SelectedItem.ToString()));
        }

        private void cb_follow_SelectedIndexChanged(object sender, EventArgs e)
        {
            FollowLikeLastsPicBot x = (FollowLikeLastsPicBot)follow_like_bot;
            if (cb_follow.SelectedItem.ToString() == "yes")
            {
                x.set_follow_accounts(true);
            }
            else
            {
                x.set_follow_accounts(false);
            }
        }

        private async Task<bool> wait(int seconds)
        {
            int i = 0;
            while (i < seconds * 2 && follow_like_bot.is_running)
            {
                await Task.Delay(500);
                i++;
            }
            return true;
        }

        private async void bt_stop_Click(object sender, EventArgs e)
        {
            if (follow_like_bot.is_running)
            {
                follow_like_bot.stop(true);

                int i = 0;
                do
                {
                    await wait(1);
                    i++;

                } while (follow_like_bot.is_running && i < 5);

                if (follow_like_bot.is_running)
                {
                    MessageBox.Show("couldn't stop bot: time out excedeed");
                }
                else
                {                    
                    actions_bot_ended();
                }
            }
        }

        private void bt_manage_lists_Click(object sender, EventArgs e)
        {
            files.refresh_files_list();
        }

        private void follow_like_form_Activated(object sender, EventArgs e)
        {
            
        }
    }
}

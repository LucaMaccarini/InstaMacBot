using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstaMacBot.classes;

namespace InstaMacBot.DesktopInterface
{
    public partial class unfollow_form : Form
    {
        //instagram user of Bot_client form 
        UserApi utente;

        //bot manager of main form
        BotClient bot_manager;

        //this bot
        SSSBot unfollow_bot;

        //console of bot
        BotConsole console;

        //direcory where save bots files
        private string path_bots_file;

        //list of all files of all bots
        bot_file_list files;

        public unfollow_form(UserApi _utente, BotClient _bot_manager, bot_file_list files)
        {
            InitializeComponent();

            utente = _utente;
            bot_manager = _bot_manager;
            path_bots_file = files.get_path();

            this.files = files;
            this.files.set_listbox(listBox_files);
        }

        private void unfollow_form_Load(object sender, EventArgs e)
        {
            SetDoubleBuffered(tabControl1);
            SetDoubleBuffered(pn_description);
            SetDoubleBuffered(pn_options);
            SetDoubleBuffered(pn_controls);
            SetDoubleBuffered(pn_controls_status);

            console = new DesktopTextBoxConsole(tx_console);

            unfollow_bot = new UnfollowBot(utente, path_bots_file, tx_console: console, actions: actions_bot_ended);
            bot_manager.bots.Add("unfollow", unfollow_bot);
        }

        private void actions_bot_ended()
        {
            pn_status.BackColor = Color.FromArgb(196, 45, 45);
            bt_start_unfollow_bot.Enabled = true;
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

        private void bt_start_unfollow_bot_Click(object sender, EventArgs e)
        {
            if (listBox_files.SelectedIndex < 0)
            {
                console.write_on_console("no source list selected");
                return;
            }


            ((UnfollowBot)unfollow_bot).load_followed_accounts(((bot_file_entry_list)listBox_files.Items[listBox_files.SelectedIndex]).get_path());
            bt_start_unfollow_bot.Enabled = false;
            pn_status.BackColor = Color.FromArgb(42, 150, 72);

            unfollow_bot.start();
        }

        private async Task<bool> wait(int seconds)
        {
            int i = 0;
            while (i < seconds * 2 && unfollow_bot.is_running)
            {
                await Task.Delay(500);
                i++;
            }
            return true;
        }

        private async void bt_stop_unfollow_bot_Click(object sender, EventArgs e)
        {
            if (unfollow_bot.is_running)
            {
                unfollow_bot.stop(true);

                int i = 0;
                do
                {
                    await wait(1);
                    i++;

                } while (unfollow_bot.is_running && i < 5);

                if (unfollow_bot.is_running)
                {
                    MessageBox.Show("couldn't stop bot: time out excedeed");
                }

            }
        }

        private void cb_delay_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnfollowBot x = (UnfollowBot)unfollow_bot;
            x.set_delay(int.Parse(cb_delay.SelectedItem.ToString()));
        }

        private void bt_manage_lists_Click(object sender, EventArgs e)
        {
            files.refresh_files_list();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pn_description_Resize(object sender, EventArgs e)
        {
            lb_description.MaximumSize = pn_description.Size;
        }
    }
}

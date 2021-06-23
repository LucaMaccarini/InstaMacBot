using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstaMacBot.classes;

namespace InstaMacBot.DesktopInterface
{
    public partial class send_dm_form : Form
    {
        //instagram user of Bot_client form 
        UserApi utente;

        //bot manager of main form
        BotClient bot_manager;

        //this bot
        SSSBot send_dm;

        //console of bot
        BotConsole console;

        //direcory where save bots files
        private string path_bots_file;

        //list of all files of all bots
        bot_file_list files;

        public send_dm_form(UserApi _utente, BotClient _bot_manager, bot_file_list files)
        {
            InitializeComponent();

            utente = _utente;
            bot_manager = _bot_manager;
            path_bots_file = files.get_path();

            this.files = files;
            this.files.set_listbox(listBox_files);
        }

        private void send_dm_form_Load(object sender, EventArgs e)
        {
            SetDoubleBuffered(tabControl1);
            SetDoubleBuffered(pn_description);
            SetDoubleBuffered(pn_options);
            SetDoubleBuffered(pn_controls);
            SetDoubleBuffered(pn_controls_status);

            console = new DesktopTextBoxConsole(tx_console);

            send_dm = new SendDmBot(utente, path_bots_file, console, actions: actions_bot_ended);
            bot_manager.bots.Add("send_dm", send_dm);
        }

        private void actions_bot_ended()
        {
            pn_status.BackColor = Color.FromArgb(196, 45, 45);
            bt_start_send_dm_bot.Enabled = true;
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
            while (i < seconds * 2 && send_dm.is_running)
            {
                await Task.Delay(500);
                i++;
            }
            return true;
        }

        private void bt_manage_lists_Click(object sender, EventArgs e)
        {
            files.refresh_files_list();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tx_message.Text == "")
            {
                console.write_on_console("no message wrote in the option tab");
                return;
            }

            ((SendDmBot)send_dm).set_message(tx_message.Text);

            if (listBox_files.SelectedIndex < 0)
            {
                console.write_on_console("no source list selected");
                return;
            }


            ((SendDmBot)send_dm).load_followed_accounts(((bot_file_entry_list)listBox_files.Items[listBox_files.SelectedIndex]).get_path());
            bt_start_send_dm_bot.Enabled = false;
            pn_status.BackColor = Color.FromArgb(42, 150, 72);

            send_dm.start();
        }

        private async void bt_stop_send_dm_bot_Click(object sender, EventArgs e)
        {
            if (send_dm.is_running)
            {
                send_dm.stop(true);

                int i = 0;
                do
                {
                    await wait(1);
                    i++;

                } while (send_dm.is_running && i < 5);

                if (send_dm.is_running)
                {
                    MessageBox.Show("couldn't stop bot: time out excedeed");
                }

            }
        }
    }
}

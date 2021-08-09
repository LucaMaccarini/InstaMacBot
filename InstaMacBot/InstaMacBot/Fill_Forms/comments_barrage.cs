using InstaMacBot.classes;
using InstaMacBot.MacBotClient_classes;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMacBot.DesktopInterface
{
    public partial class comments_barrage : Form
    {
        //instagram user of Bot_client form 
        UserApi utente;

        //bot manager of main form
        BotClient bot_manager;

        //this bot
        SSSBot comments_barrage_bot;

        //console of bot
        BotConsole console;

        //direcory where save bots files
        private string path_bots_file;

        //list of all files of all bots
        //bot_file_list files;

        public comments_barrage(UserApi _utente, BotClient _bot_manager, bot_file_list files)
        {
            InitializeComponent();
            utente = _utente;
            bot_manager = _bot_manager;
            path_bots_file = files.get_path();

        }

        private void comments_barrage_Load(object sender, EventArgs e)
        {
            SetDoubleBuffered(tabControl1);
            SetDoubleBuffered(pn_description);
            SetDoubleBuffered(pn_options);
            SetDoubleBuffered(pn_controls);
            SetDoubleBuffered(pn_controls_status);
            SetDoubleBuffered(pn_console);

            lb_description.MaximumSize = pn_description.Size;

            console = new DesktopTextBoxConsole(tx_console);

            comments_barrage_bot = new CommentsBarrageBot(utente, path_bots_file, tx_console: console, actions: actions_bot_ended);
            bot_manager.bots.Add("comments_barrage", comments_barrage_bot);
        }

        private void actions_bot_ended()
        {
            pn_status.BackColor = Color.FromArgb(196, 45, 45);
            bt_comments_barrage_bot.Enabled = true;
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

 

        private void nm_limit_of_comments_ValueChanged(object sender, EventArgs e)
        {
            CommentsBarrageBot x = (CommentsBarrageBot)comments_barrage_bot;
            x.set_comments_limit(Convert.ToInt32(nm_limit_of_comments.Value));
        }

        private async void bt_comments_barrage_bot_Click(object sender, EventArgs e)
        {
            bt_comments_barrage_bot.Enabled = false;
            pn_status.BackColor = Color.FromArgb(42, 150, 72);

            CommentsBarrageBot x = (CommentsBarrageBot)comments_barrage_bot;
            x.set_target_post(tx_target_post_link.Text);
            x.set_text_comment(tx_comment_content.Text);

            comments_barrage_bot.start();
        }

      
        private void bt_stop_like_follow_bot_Click(object sender, EventArgs e)
        {
            if (comments_barrage_bot.is_running)
            {
                comments_barrage_bot.stop(true);
            }
        }

        private void nm_delay_ValueChanged(object sender, EventArgs e)
        {
            CommentsBarrageBot x = (CommentsBarrageBot)comments_barrage_bot;
            x.set_delay(Convert.ToInt32(nm_delay.Value));
        }


        
    }
}

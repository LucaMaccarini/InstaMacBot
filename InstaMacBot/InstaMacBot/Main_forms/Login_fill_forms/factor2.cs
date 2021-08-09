using InstaMacBot.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMacBot.DesktopInterface
{
    public partial class factor2 : Form
    {
        Form login_form;
        UserApi utente;
        string username;
        bool session;

        public factor2(Form login_form)
        {
            InitializeComponent();
            this.login_form = login_form;

            utente = null;
            username = null;
            session = false;
        }

        private void factor2_Load(object sender, EventArgs e)
        {

        }

        public bool is_panel_unlocked()
        {
            return pn_container_fill_form.Enabled;
        }

        public void lock_panel()
        {
            tx_2factorCode.Text = "";
            pn_container_fill_form.Enabled = false;
            lb_alert.BackColor = Color.FromArgb(120, 255, 0, 0);
            lb_alert.Text = "To unlock this first login with credentials";
        }
        public void unlock_panel(UserApi x, string username, bool session)
        {
            pn_container_fill_form.Enabled = true;
            lb_alert.BackColor = Color.FromArgb(76, 134, 89);
            lb_alert.Text = "2 Factor login unlocked";
            this.username = username;
            this.session = session;
            utente = x;
        }

        private void pn_container_fill_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void bt_send_Click(object sender, EventArgs e)
        {

            if (username == null || utente == null) throw new Exception("utente and username must be != null");
            if (tx_2factorCode.Text == "")
            {
                MessageBox.Show("fill 2 factor code textbox", "input 2 factor code");
                return;
            }

            bt_send.Enabled = false;


            string result = await utente.Send2factorCodeAsync(tx_2factorCode.Text);
            bt_send.Enabled = true;

            if (result != "")
            {
                MessageBox.Show(result, "2 factor error");
                return;
            }
            

            Bot_Client form_client_bot = new Bot_Client(utente, "./Accounts/" + username, session);
            login_form.Hide();
            form_client_bot.Closed += (s, args) => login_form.Close();
            form_client_bot.Show();
        }
    }
}

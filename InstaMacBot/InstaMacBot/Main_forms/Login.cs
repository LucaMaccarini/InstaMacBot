using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMacBot
{
    public partial class Login : Form
    {
        UserApi utente;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not aviable for now", "2 Factor login");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void bt_login_Click(object sender, EventArgs e)
        {
            bt_login.Enabled = false;

            if (!Directory.Exists("./Accounts"))
                Directory.CreateDirectory("./Accounts");

            if (tx_login_username.Text == "" || tx_login_password.Text == "")
            {
                MessageBox.Show("fill username and password", "invalid credentials");
                bt_login.Enabled = true;
                return;
            }

            utente = new UserApi(tx_login_username.Text, tx_login_password.Text);

            string esito = await utente.loginAsync();

            if (!utente.is_logged)
            {
                MessageBox.Show(esito, "Login error");
                bt_login.Enabled = true;
                return;
            }


            this.Hide();
            Bot_Client form_client_bot = new Bot_Client(utente, "./Accounts/" + tx_login_username.Text);
            form_client_bot.Closed += (s, args) => this.Close();
            form_client_bot.Show();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

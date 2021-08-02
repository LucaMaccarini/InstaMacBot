using InstaMacBot.classes;
using InstaMacBot.DesktopInterface;
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

namespace InstaMacBot.DesktopInterface
{
    public partial class username_password : Form
    {

        UserApi utente;
        Form login_form;

        public username_password(Login login_form)
        {
            InitializeComponent();
            this.login_form = login_form;
        }

        

        private async void bt_login_Click(object sender, EventArgs e)
        {
            bt_login.Enabled = false;

            if (tx_login_username.Text == "" || tx_login_password.Text == "")
            {
                MessageBox.Show("fill username and password", "invalid credentials");
                bt_login.Enabled = true;
                return;
            }

            utente = new UserApi(tx_login_username.Text, tx_login_password.Text);

            string esito = await utente.loginAsync();

            if (!utente.is_autentitcated)
            {
                MessageBox.Show(esito, "Login error");
                bt_login.Enabled = true;
                return;
            }

            Bot_Client form_client_bot = new Bot_Client(utente, "./Accounts/" + tx_login_username.Text, ck_save_session.Checked);
            login_form.Hide();
            form_client_bot.Closed += (s, args) => login_form.Close();
            form_client_bot.Show();
        }

        

        /*
        private async void load_sesion()
        {
            check_accounts_folders();
            string path = "C:/Users/lucam/Desktop/InstaMacBot/InstaMacBot/InstaMacBot/bin/Debug/Accounts/chiara_rampolla/chiara_rampolla session.json";

            string json;

            using (StreamReader reader = new StreamReader(path))
            {

                json = reader.ReadLine();

            }

            UserApi utente = await UserApi.Get_userApi_from_session(json);


            this.Hide();
            Bot_Client form_client_bot = new Bot_Client(utente, "./Accounts/" + tx_login_username.Text, ck_save_session.Checked);
            form_client_bot.Closed += (s, args) => this.Close();
            form_client_bot.Show();

        }*/

        private void username_password_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("it is good to save the session because:" + "\n\n" +
                "1) you will not have to log back into your account from the bot every time so instagram will not detect a new login and will not be suspicious" + "\n\n" +
                "2) you will be able to log in later in your account in the load session section" + "\n\n" +
                "3) note: saving the session will save your password in clear text in the <your username>.json file that is your session file, in the Sessions folder. " +
                "This means that anyone who has access to that file will be able to see your instagram password" + "\n\n" +
                "4) if you have no problems with other people who can access the json file and see your password, i highly recommend that you save the session at the first access and perform subsequent accesses through the load session section (which will keep the session updated)"
                , "Why save the session?");
        }
    }
}

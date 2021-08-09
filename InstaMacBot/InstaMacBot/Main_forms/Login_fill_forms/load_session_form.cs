using InstaMacBot.classes;
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
    public partial class load_session_form : Form
    {
        Form login_form;
        bot_file_list bot_session_list;
        public load_session_form(Login login_form)
        {
            InitializeComponent();
            this.login_form = login_form;
            bot_session_list = new bot_file_list("./Sessions", "json");
            
        }

        private void load_session_form_Load(object sender, EventArgs e)
        {
            bot_session_list.set_listbox(session_list);
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            bot_file_entry_list entry = (bot_file_entry_list)session_list.Items[session_list.SelectedIndex];
            string path_session_json_file=entry.get_path();
            load_sesion(path_session_json_file);

        }

        private async void load_sesion(string path_file)
        {
            string path = path_file;

            string json;

            using (StreamReader reader = new StreamReader(path))
            {

                json = reader.ReadLine();

            }

            UserApi utente = null;

            try
            {
                utente = await UserApi.Get_userApi_from_session(json);
            }catch(Exception e)
            {
                MessageBox.Show("Invalid json file", "json parsing error");
                return;
            }

            if (utente == null)
            {
                MessageBox.Show("session no longer valid", "Load Session Error");
                return;
            }


            login_form.Hide();
            Bot_Client form_client_bot = new Bot_Client(utente, "./Accounts/" + utente.get_username(), true);
            form_client_bot.Closed += (s, args) => login_form.Close();
            form_client_bot.Show();

        }
    }
}

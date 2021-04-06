using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMacBot.MacBotClient_classes
{
    public partial class message_form : Form
    {
        public message_form()
        {
            InitializeComponent();
        }

        public void set_message(string mess)
        {
            tx_messaggio.Text = mess;
        }

        public string get_message()
        {
            return tx_messaggio.Text;
        }

        public void set_link(string link)
        {
            tx_link.Text= link;
        }

        public void set_check_link(bool value)
        {
            check_link.Checked = value;
        }
        public string get_link()
        {
            if (check_link.Checked)
                return tx_link.Text;
            else
                return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tx_link.Enabled = false;
            MessageBox.Show("not aviable for now");
        }
    }
}

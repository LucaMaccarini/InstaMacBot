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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

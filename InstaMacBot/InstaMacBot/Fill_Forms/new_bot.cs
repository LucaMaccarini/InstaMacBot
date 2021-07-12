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
    public partial class new_bot : Form
    {
        public new_bot()
        {
            InitializeComponent();
        }

        private void new_bot_Load(object sender, EventArgs e)
        {
            SetDoubleBuffered(pn_main);
        }
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

        private void pn_main_Resize(object sender, EventArgs e)
        {
            lb_1.MaximumSize = pn_main.Size;
            lb_2.MaximumSize = pn_main.Size;
            lb_3.MaximumSize = pn_main.Size;
            lb_4.MaximumSize = pn_main.Size;
        }

        private void bt_manage_lists_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MaccariniLuca/InstaMacBot/releases");
        }
    }
}

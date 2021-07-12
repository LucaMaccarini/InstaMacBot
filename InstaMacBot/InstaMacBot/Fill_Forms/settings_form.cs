using System;
using System.Windows.Forms;
using InstaMacBot.classes;


namespace InstaMacBot.DesktopInterface
{
    public partial class settings_form : Form
    {
        public settings_form()
        {
            InitializeComponent();
        }

        private void settings_form_Load(object sender, EventArgs e)
        {
            SetDoubleBuffered(pn_settings);
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
    }
}

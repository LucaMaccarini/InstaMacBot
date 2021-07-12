using System;
using System.Windows.Forms;
using InstaMacBot.classes;

namespace InstaMacBot.DesktopInterface
{
    public partial class manage_lists_form : Form
    {
        //list of all files of all bots
        bot_file_list files;

        public manage_lists_form(bot_file_list files)
        {
            InitializeComponent();
            this.files = files;
            this.files.refresh_files_list();
            this.files.set_listbox(listBox_files);
        }



        private void manage_lists_Load(object sender, EventArgs e)
        {
            SetDoubleBuffered(tabControl1);
            SetDoubleBuffered(pn_description);
            SetDoubleBuffered(pn_lists);
            SetDoubleBuffered(pn_controls);

            lb_description.MaximumSize = this.Size;

            this.files.refresh_files_list();
            this.files.set_listbox(listBox_files);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            files.refresh_files_list();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bot_file_entry_list item = (bot_file_entry_list)listBox_files.Items[listBox_files.SelectedIndex];
            item.remove();

            files.refresh_files_list();
        }



        private void manage_lists_form_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("z");
        }

        private void manage_lists_form_Resize(object sender, EventArgs e)
        {

        }

        private void lb_description_Click(object sender, EventArgs e)
        {

        }

        private void pn_description_Resize(object sender, EventArgs e)
        {
            lb_description.MaximumSize = pn_description.Size;
        }
    }
}

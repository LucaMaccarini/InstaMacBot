using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using InstaMacBot.classes;

namespace InstaMacBot.DesktopInterface
{
    public partial class Login : Form
    {
        UserApi utente;

        Form username_password_form;
        Form factor2_form;
        Form load_session_form;

        public Login()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            select_login_method(bt_2factor);
            open_fill_form(factor2_form);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void check_accounts_folders()
        {
            if (!Directory.Exists("./Accounts"))
                Directory.CreateDirectory("./Accounts");

            if (!Directory.Exists("./Sessions"))
                Directory.CreateDirectory("./Sessions");

        }


        Form activeForm=null;

        private void open_fill_form(Form fill_form)
        {
            if (activeForm != null && fill_form!=activeForm)
                activeForm.Hide();

            if (fill_form != activeForm)
            {
                activeForm = fill_form;
                fill_form.TopLevel = false;
                fill_form.FormBorderStyle = FormBorderStyle.None;
                fill_form.Dock = DockStyle.Fill;
                pn_container_fill_form.Controls.Add(fill_form);
                //pn_manage_your_list.Tag = fill_form;
                fill_form.BringToFront();
                fill_form.Show();
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            username_password_form = new username_password(this);
            factor2_form = new factor2(this);
            load_session_form = new load_session_form(this);

            open_fill_form(username_password_form);

            selected_login_method = bt_login;
            check_accounts_folders();

            SetDoubleBuffered(panel1);
            SetDoubleBuffered(panel2);
            SetDoubleBuffered(pn1);
            SetDoubleBuffered(pn_container_fill_form);


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



        Button selected_login_method = null;
        private void select_login_method(Button button_clicked)
        {
            if (selected_login_method == null)
            {
                selected_login_method = button_clicked;
                button_clicked.BackColor = Color.FromArgb(75, 65, 103);
                button_clicked.ForeColor = Color.White;
            }
            else
            {
                if (button_clicked == selected_login_method)
                    return;

                button_clicked.BackColor = Color.FromArgb(75, 65, 103);
                button_clicked.ForeColor = Color.White;

                selected_login_method.ForeColor = Color.Black;
                selected_login_method.BackColor = Color.FromArgb(120, 255, 255, 255);

                selected_login_method = button_clicked;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            //load_sesion();
            select_login_method(bt_session);
            open_fill_form(load_session_form);
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            select_login_method(bt_login);
            open_fill_form(username_password_form);
        }
    }
}

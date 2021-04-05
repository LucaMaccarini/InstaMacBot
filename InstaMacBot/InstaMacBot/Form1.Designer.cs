namespace InstaMacBot
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_username = new System.Windows.Forms.TextBox();
            this.tx_password = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.lb_info = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_console = new System.Windows.Forms.TextBox();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_salva_su_file = new System.Windows.Forms.Button();
            this.lb_follower_estratti_o_caricati = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_username_estrai_followers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_comandi = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.console_extract = new System.Windows.Forms.TextBox();
            this.tab_comandi1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_console_unfollow = new System.Windows.Forms.TextBox();
            this.lb_seguiti_caricati = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_stop_unfollow = new System.Windows.Forms.Button();
            this.bt_start_unfollow = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.tx_console_hastag = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tx_hastag = new System.Windows.Forms.TextBox();
            this.tab_comandi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab_comandi1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // tx_username
            // 
            this.tx_username.Location = new System.Drawing.Point(158, 9);
            this.tx_username.Name = "tx_username";
            this.tx_username.Size = new System.Drawing.Size(167, 20);
            this.tx_username.TabIndex = 2;
            this.tx_username.Text = "gasdgaedga";
            // 
            // tx_password
            // 
            this.tx_password.Location = new System.Drawing.Point(158, 35);
            this.tx_password.Name = "tx_password";
            this.tx_password.PasswordChar = '*';
            this.tx_password.Size = new System.Drawing.Size(167, 20);
            this.tx_password.TabIndex = 3;
            this.tx_password.Text = "Masserini1";
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(96, 61);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(56, 24);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.Enabled = false;
            this.bt_logout.Location = new System.Drawing.Point(158, 61);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(56, 24);
            this.bt_logout.TabIndex = 5;
            this.bt_logout.Text = "logout";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Location = new System.Drawing.Point(306, 12);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(0, 13);
            this.lb_info.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "console";
            // 
            // tx_console
            // 
            this.tx_console.Location = new System.Drawing.Point(6, 138);
            this.tx_console.Multiline = true;
            this.tx_console.Name = "tx_console";
            this.tx_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_console.Size = new System.Drawing.Size(566, 230);
            this.tx_console.TabIndex = 16;
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(78, 81);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(66, 24);
            this.bt_stop.TabIndex = 9;
            this.bt_stop.Text = "stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(6, 81);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(66, 24);
            this.bt_start.TabIndex = 8;
            this.bt_start.Text = "start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 24);
            this.button3.TabIndex = 10;
            this.button3.Text = "Load list accounts file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_salva_su_file
            // 
            this.bt_salva_su_file.Location = new System.Drawing.Point(350, 37);
            this.bt_salva_su_file.Name = "bt_salva_su_file";
            this.bt_salva_su_file.Size = new System.Drawing.Size(118, 24);
            this.bt_salva_su_file.TabIndex = 8;
            this.bt_salva_su_file.Text = "Save on file";
            this.bt_salva_su_file.UseVisualStyleBackColor = true;
            this.bt_salva_su_file.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_follower_estratti_o_caricati
            // 
            this.lb_follower_estratti_o_caricati.AutoSize = true;
            this.lb_follower_estratti_o_caricati.Location = new System.Drawing.Point(923, 146);
            this.lb_follower_estratti_o_caricati.Name = "lb_follower_estratti_o_caricati";
            this.lb_follower_estratti_o_caricati.Size = new System.Drawing.Size(0, 13);
            this.lb_follower_estratti_o_caricati.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "extract";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_username_estrai_followers
            // 
            this.tx_username_estrai_followers.Location = new System.Drawing.Point(110, 40);
            this.tx_username_estrai_followers.Name = "tx_username_estrai_followers";
            this.tx_username_estrai_followers.Size = new System.Drawing.Size(161, 20);
            this.tx_username_estrai_followers.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "extract followers of:";
            // 
            // tab_comandi
            // 
            this.tab_comandi.Controls.Add(this.tabPage1);
            this.tab_comandi.Controls.Add(this.tabPage3);
            this.tab_comandi.Controls.Add(this.tab_comandi1);
            this.tab_comandi.Controls.Add(this.tabPage2);
            this.tab_comandi.Enabled = false;
            this.tab_comandi.Location = new System.Drawing.Point(8, 126);
            this.tab_comandi.Name = "tab_comandi";
            this.tab_comandi.SelectedIndex = 0;
            this.tab_comandi.Size = new System.Drawing.Size(876, 400);
            this.tab_comandi.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.console_extract);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bt_salva_su_file);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tx_username_estrai_followers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(868, 374);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Scrape from user";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "console";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(6, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "For more safety scrape users logged with a fake or unless account";
            // 
            // console_extract
            // 
            this.console_extract.Location = new System.Drawing.Point(3, 83);
            this.console_extract.Multiline = true;
            this.console_extract.Name = "console_extract";
            this.console_extract.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console_extract.Size = new System.Drawing.Size(465, 285);
            this.console_extract.TabIndex = 19;
            // 
            // tab_comandi1
            // 
            this.tab_comandi1.Controls.Add(this.groupBox1);
            this.tab_comandi1.Controls.Add(this.label11);
            this.tab_comandi1.Controls.Add(this.label10);
            this.tab_comandi1.Controls.Add(this.button5);
            this.tab_comandi1.Controls.Add(this.label8);
            this.tab_comandi1.Controls.Add(this.button3);
            this.tab_comandi1.Controls.Add(this.tx_console);
            this.tab_comandi1.Controls.Add(this.bt_stop);
            this.tab_comandi1.Controls.Add(this.bt_start);
            this.tab_comandi1.Location = new System.Drawing.Point(4, 22);
            this.tab_comandi1.Name = "tab_comandi1";
            this.tab_comandi1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_comandi1.Size = new System.Drawing.Size(868, 374);
            this.tab_comandi1.TabIndex = 0;
            this.tab_comandi1.Text = "follow and like last pic";
            this.tab_comandi1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(578, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 359);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "bot settings";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(240, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "change delay between each account (default 40)";
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "1";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "30",
            "40",
            "50",
            "60",
            "70",
            "80"});
            this.comboBox2.Location = new System.Drawing.Point(9, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(48, 21);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "change numbers of likes at each account (default 1)";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(9, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(48, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(3, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Bot commands";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(6, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "First load an account list file where bot will operate";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(150, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 24);
            this.button5.TabIndex = 18;
            this.button5.Text = "check bot status";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_3);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tx_console_unfollow);
            this.tabPage2.Controls.Add(this.lb_seguiti_caricati);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.bt_stop_unfollow);
            this.tabPage2.Controls.Add(this.bt_start_unfollow);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(868, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "unfollow";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.ForestGreen;
            this.label15.Location = new System.Drawing.Point(6, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Bot commands";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(3, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(243, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "First load an account list file where bot will operate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(578, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 359);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "bot settings";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "change delay between each account (default 50)";
            // 
            // comboBox3
            // 
            this.comboBox3.DisplayMember = "1";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "40",
            "50",
            "60",
            "70",
            "80",
            "90"});
            this.comboBox3.Location = new System.Drawing.Point(9, 42);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(48, 21);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(150, 79);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 24);
            this.button6.TabIndex = 27;
            this.button6.Text = "check bot status";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "console";
            // 
            // tx_console_unfollow
            // 
            this.tx_console_unfollow.Location = new System.Drawing.Point(3, 137);
            this.tx_console_unfollow.Multiline = true;
            this.tx_console_unfollow.Name = "tx_console_unfollow";
            this.tx_console_unfollow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_console_unfollow.Size = new System.Drawing.Size(569, 231);
            this.tx_console_unfollow.TabIndex = 23;
            // 
            // lb_seguiti_caricati
            // 
            this.lb_seguiti_caricati.AutoSize = true;
            this.lb_seguiti_caricati.Location = new System.Drawing.Point(120, 11);
            this.lb_seguiti_caricati.Name = "lb_seguiti_caricati";
            this.lb_seguiti_caricati.Size = new System.Drawing.Size(0, 13);
            this.lb_seguiti_caricati.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Load list accounts file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // bt_stop_unfollow
            // 
            this.bt_stop_unfollow.Location = new System.Drawing.Point(78, 79);
            this.bt_stop_unfollow.Name = "bt_stop_unfollow";
            this.bt_stop_unfollow.Size = new System.Drawing.Size(66, 24);
            this.bt_stop_unfollow.TabIndex = 24;
            this.bt_stop_unfollow.Text = "stop";
            this.bt_stop_unfollow.UseVisualStyleBackColor = true;
            this.bt_stop_unfollow.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // bt_start_unfollow
            // 
            this.bt_start_unfollow.Location = new System.Drawing.Point(6, 79);
            this.bt_start_unfollow.Name = "bt_start_unfollow";
            this.bt_start_unfollow.Size = new System.Drawing.Size(66, 24);
            this.bt_start_unfollow.TabIndex = 23;
            this.bt_start_unfollow.Text = "start";
            this.bt_start_unfollow.UseVisualStyleBackColor = true;
            this.bt_start_unfollow.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "BOTS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.tx_console_hastag);
            this.tabPage3.Controls.Add(this.tx_hastag);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(868, 374);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Scrape form hastag";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(10, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(447, 18);
            this.label16.TabIndex = 30;
            this.label16.Text = "For more safety scrape users logged with a fake or unless account";
            // 
            // tx_console_hastag
            // 
            this.tx_console_hastag.Location = new System.Drawing.Point(7, 79);
            this.tx_console_hastag.Multiline = true;
            this.tx_console_hastag.Name = "tx_console_hastag";
            this.tx_console_hastag.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_console_hastag.Size = new System.Drawing.Size(465, 285);
            this.tx_console_hastag.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "extract followers of:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 24);
            this.button2.TabIndex = 27;
            this.button2.Text = "Save on file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(281, 33);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 24);
            this.button7.TabIndex = 28;
            this.button7.Text = "extract";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tx_hastag
            // 
            this.tx_hastag.Location = new System.Drawing.Point(114, 36);
            this.tx_hastag.Name = "tx_hastag";
            this.tx_hastag.Size = new System.Drawing.Size(161, 20);
            this.tx_hastag.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tab_comandi);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tx_password);
            this.Controls.Add(this.tx_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_follower_estratti_o_caricati);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "InstaMacbot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tab_comandi.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab_comandi1.ResumeLayout(false);
            this.tab_comandi1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_username;
        private System.Windows.Forms.TextBox tx_password;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_username_estrai_followers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_salva_su_file;
        private System.Windows.Forms.Label lb_follower_estratti_o_caricati;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tx_console;
        private System.Windows.Forms.TabControl tab_comandi;
        private System.Windows.Forms.TabPage tab_comandi1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lb_seguiti_caricati;
        private System.Windows.Forms.Button bt_stop_unfollow;
        private System.Windows.Forms.Button bt_start_unfollow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_console_unfollow;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox console_extract;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tx_console_hastag;
        private System.Windows.Forms.TextBox tx_hastag;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
    }
}


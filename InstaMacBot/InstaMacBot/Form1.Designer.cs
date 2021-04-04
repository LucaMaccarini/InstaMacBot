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
            this.console_extract = new System.Windows.Forms.TextBox();
            this.tab_comandi1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_console_unfollow = new System.Windows.Forms.TextBox();
            this.lb_seguiti_caricati = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_stop_unfollow = new System.Windows.Forms.Button();
            this.bt_start_unfollow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tab_comandi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab_comandi1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // tx_username
            // 
            this.tx_username.Location = new System.Drawing.Point(70, 6);
            this.tx_username.Name = "tx_username";
            this.tx_username.Size = new System.Drawing.Size(167, 20);
            this.tx_username.TabIndex = 2;
            // 
            // tx_password
            // 
            this.tx_password.Location = new System.Drawing.Point(70, 32);
            this.tx_password.Name = "tx_password";
            this.tx_password.PasswordChar = '*';
            this.tx_password.Size = new System.Drawing.Size(167, 20);
            this.tx_password.TabIndex = 3;
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(8, 58);
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
            this.bt_logout.Location = new System.Drawing.Point(70, 58);
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
            this.lb_info.Location = new System.Drawing.Point(194, 9);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(0, 13);
            this.lb_info.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "console";
            // 
            // tx_console
            // 
            this.tx_console.Location = new System.Drawing.Point(6, 90);
            this.tx_console.Multiline = true;
            this.tx_console.Name = "tx_console";
            this.tx_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_console.Size = new System.Drawing.Size(552, 219);
            this.tx_console.TabIndex = 16;
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(78, 36);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(66, 24);
            this.bt_stop.TabIndex = 9;
            this.bt_stop.Text = "stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(6, 36);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(66, 24);
            this.bt_start.TabIndex = 8;
            this.bt_start.Text = "start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 6);
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
            this.tab_comandi.Controls.Add(this.tab_comandi1);
            this.tab_comandi.Controls.Add(this.tabPage2);
            this.tab_comandi.Enabled = false;
            this.tab_comandi.Location = new System.Drawing.Point(8, 119);
            this.tab_comandi.Name = "tab_comandi";
            this.tab_comandi.SelectedIndex = 0;
            this.tab_comandi.Size = new System.Drawing.Size(566, 339);
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
            this.tabPage1.Size = new System.Drawing.Size(558, 313);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Scrape from user";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // console_extract
            // 
            this.console_extract.Location = new System.Drawing.Point(3, 83);
            this.console_extract.Multiline = true;
            this.console_extract.Name = "console_extract";
            this.console_extract.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console_extract.Size = new System.Drawing.Size(552, 223);
            this.console_extract.TabIndex = 19;
            // 
            // tab_comandi1
            // 
            this.tab_comandi1.Controls.Add(this.button5);
            this.tab_comandi1.Controls.Add(this.label8);
            this.tab_comandi1.Controls.Add(this.button3);
            this.tab_comandi1.Controls.Add(this.tx_console);
            this.tab_comandi1.Controls.Add(this.bt_stop);
            this.tab_comandi1.Controls.Add(this.bt_start);
            this.tab_comandi1.Location = new System.Drawing.Point(4, 22);
            this.tab_comandi1.Name = "tab_comandi1";
            this.tab_comandi1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_comandi1.Size = new System.Drawing.Size(558, 313);
            this.tab_comandi1.TabIndex = 0;
            this.tab_comandi1.Text = "follow / like";
            this.tab_comandi1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(150, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 24);
            this.button5.TabIndex = 18;
            this.button5.Text = "check bot status";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_3);
            // 
            // tabPage2
            // 
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
            this.tabPage2.Size = new System.Drawing.Size(558, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "unfollow";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(150, 35);
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
            this.label5.Location = new System.Drawing.Point(3, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "console";
            // 
            // tx_console_unfollow
            // 
            this.tx_console_unfollow.Location = new System.Drawing.Point(3, 93);
            this.tx_console_unfollow.Multiline = true;
            this.tx_console_unfollow.Name = "tx_console_unfollow";
            this.tx_console_unfollow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_console_unfollow.Size = new System.Drawing.Size(552, 213);
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
            this.button4.Location = new System.Drawing.Point(6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Load list accounts file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // bt_stop_unfollow
            // 
            this.bt_stop_unfollow.Location = new System.Drawing.Point(78, 35);
            this.bt_stop_unfollow.Name = "bt_stop_unfollow";
            this.bt_stop_unfollow.Size = new System.Drawing.Size(66, 24);
            this.bt_stop_unfollow.TabIndex = 24;
            this.bt_stop_unfollow.Text = "stop";
            this.bt_stop_unfollow.UseVisualStyleBackColor = true;
            this.bt_stop_unfollow.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // bt_start_unfollow
            // 
            this.bt_start_unfollow.Location = new System.Drawing.Point(6, 35);
            this.bt_start_unfollow.Name = "bt_start_unfollow";
            this.bt_start_unfollow.Size = new System.Drawing.Size(66, 24);
            this.bt_start_unfollow.TabIndex = 23;
            this.bt_start_unfollow.Text = "start";
            this.bt_start_unfollow.UseVisualStyleBackColor = true;
            this.bt_start_unfollow.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "For more safety scrape users logged with a fake or unless account";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "BOTS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 459);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "InstaMacbot follow - like";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tab_comandi.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab_comandi1.ResumeLayout(false);
            this.tab_comandi1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}


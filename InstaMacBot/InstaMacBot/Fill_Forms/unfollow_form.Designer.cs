
namespace InstaMacBot
{
    partial class unfollow_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pn_description = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox_files = new System.Windows.Forms.ListBox();
            this.pn_options = new System.Windows.Forms.Panel();
            this.bt_manage_lists = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_delay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pn_controls = new System.Windows.Forms.Panel();
            this.pn_console = new System.Windows.Forms.Panel();
            this.tx_console = new System.Windows.Forms.TextBox();
            this.pn_controls_status = new System.Windows.Forms.Panel();
            this.bt_stop_unfollow_bot = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pn_status = new System.Windows.Forms.Panel();
            this.bt_start_unfollow_bot = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pn_description.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pn_options.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pn_controls.SuspendLayout();
            this.pn_console.SuspendLayout();
            this.pn_controls_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(85, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 548);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.tabPage1.Controls.Add(this.pn_description);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(678, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Descrizione";
            // 
            // pn_description
            // 
            this.pn_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_description.Controls.Add(this.label1);
            this.pn_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_description.Location = new System.Drawing.Point(2, 3);
            this.pn_description.Name = "pn_description";
            this.pn_description.Size = new System.Drawing.Size(674, 513);
            this.pn_description.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "bla bla bla";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.tabPage2.Controls.Add(this.listBox_files);
            this.tabPage2.Controls.Add(this.pn_options);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(678, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            // 
            // listBox_files
            // 
            this.listBox_files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.listBox_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_files.ForeColor = System.Drawing.Color.White;
            this.listBox_files.FormattingEnabled = true;
            this.listBox_files.ItemHeight = 20;
            this.listBox_files.Location = new System.Drawing.Point(2, 246);
            this.listBox_files.Name = "listBox_files";
            this.listBox_files.Size = new System.Drawing.Size(674, 270);
            this.listBox_files.TabIndex = 28;
            // 
            // pn_options
            // 
            this.pn_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_options.Controls.Add(this.bt_manage_lists);
            this.pn_options.Controls.Add(this.label7);
            this.pn_options.Controls.Add(this.label6);
            this.pn_options.Controls.Add(this.cb_delay);
            this.pn_options.Controls.Add(this.label3);
            this.pn_options.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_options.Location = new System.Drawing.Point(2, 3);
            this.pn_options.Name = "pn_options";
            this.pn_options.Size = new System.Drawing.Size(674, 243);
            this.pn_options.TabIndex = 1;
            // 
            // bt_manage_lists
            // 
            this.bt_manage_lists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_manage_lists.FlatAppearance.BorderSize = 0;
            this.bt_manage_lists.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.bt_manage_lists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_manage_lists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_manage_lists.Location = new System.Drawing.Point(552, 206);
            this.bt_manage_lists.Name = "bt_manage_lists";
            this.bt_manage_lists.Size = new System.Drawing.Size(118, 33);
            this.bt_manage_lists.TabIndex = 29;
            this.bt_manage_lists.Text = "Refresh list";
            this.bt_manage_lists.UseVisualStyleBackColor = false;
            this.bt_manage_lists.Click += new System.EventHandler(this.bt_manage_lists_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Select list were bot will execute";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "If not selected bot uses default values";
            // 
            // cb_delay
            // 
            this.cb_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.cb_delay.DisplayMember = "1";
            this.cb_delay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_delay.ForeColor = System.Drawing.Color.White;
            this.cb_delay.FormattingEnabled = true;
            this.cb_delay.Items.AddRange(new object[] {
            "30",
            "40",
            "50",
            "60",
            "70",
            "80"});
            this.cb_delay.Location = new System.Drawing.Point(6, 29);
            this.cb_delay.Name = "cb_delay";
            this.cb_delay.Size = new System.Drawing.Size(74, 28);
            this.cb_delay.TabIndex = 23;
            this.cb_delay.SelectedIndexChanged += new System.EventHandler(this.cb_delay_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delay between each account (default: 50)";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.tabPage3.Controls.Add(this.pn_controls);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage3.Size = new System.Drawing.Size(678, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Controls";
            // 
            // pn_controls
            // 
            this.pn_controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_controls.Controls.Add(this.pn_console);
            this.pn_controls.Controls.Add(this.pn_controls_status);
            this.pn_controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_controls.Location = new System.Drawing.Point(2, 3);
            this.pn_controls.Name = "pn_controls";
            this.pn_controls.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.pn_controls.Size = new System.Drawing.Size(674, 513);
            this.pn_controls.TabIndex = 2;
            // 
            // pn_console
            // 
            this.pn_console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pn_console.Controls.Add(this.tx_console);
            this.pn_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_console.Location = new System.Drawing.Point(5, 128);
            this.pn_console.Name = "pn_console";
            this.pn_console.Size = new System.Drawing.Size(664, 380);
            this.pn_console.TabIndex = 8;
            // 
            // tx_console
            // 
            this.tx_console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.tx_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tx_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_console.ForeColor = System.Drawing.Color.White;
            this.tx_console.Location = new System.Drawing.Point(0, 0);
            this.tx_console.Multiline = true;
            this.tx_console.Name = "tx_console";
            this.tx_console.ReadOnly = true;
            this.tx_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_console.Size = new System.Drawing.Size(664, 380);
            this.tx_console.TabIndex = 7;
            // 
            // pn_controls_status
            // 
            this.pn_controls_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pn_controls_status.Controls.Add(this.bt_stop_unfollow_bot);
            this.pn_controls_status.Controls.Add(this.label5);
            this.pn_controls_status.Controls.Add(this.pn_status);
            this.pn_controls_status.Controls.Add(this.bt_start_unfollow_bot);
            this.pn_controls_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_controls_status.Location = new System.Drawing.Point(5, 0);
            this.pn_controls_status.Name = "pn_controls_status";
            this.pn_controls_status.Size = new System.Drawing.Size(664, 128);
            this.pn_controls_status.TabIndex = 7;
            // 
            // bt_stop_unfollow_bot
            // 
            this.bt_stop_unfollow_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bt_stop_unfollow_bot.FlatAppearance.BorderSize = 0;
            this.bt_stop_unfollow_bot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_stop_unfollow_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stop_unfollow_bot.Location = new System.Drawing.Point(77, 47);
            this.bt_stop_unfollow_bot.Name = "bt_stop_unfollow_bot";
            this.bt_stop_unfollow_bot.Size = new System.Drawing.Size(65, 31);
            this.bt_stop_unfollow_bot.TabIndex = 7;
            this.bt_stop_unfollow_bot.Text = "Stop";
            this.bt_stop_unfollow_bot.UseVisualStyleBackColor = false;
            this.bt_stop_unfollow_bot.Click += new System.EventHandler(this.bt_stop_unfollow_bot_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bot status";
            // 
            // pn_status
            // 
            this.pn_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_status.Location = new System.Drawing.Point(92, 10);
            this.pn_status.Name = "pn_status";
            this.pn_status.Size = new System.Drawing.Size(24, 24);
            this.pn_status.TabIndex = 3;
            // 
            // bt_start_unfollow_bot
            // 
            this.bt_start_unfollow_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.bt_start_unfollow_bot.FlatAppearance.BorderSize = 0;
            this.bt_start_unfollow_bot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_start_unfollow_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start_unfollow_bot.Location = new System.Drawing.Point(3, 47);
            this.bt_start_unfollow_bot.Name = "bt_start_unfollow_bot";
            this.bt_start_unfollow_bot.Size = new System.Drawing.Size(65, 31);
            this.bt_start_unfollow_bot.TabIndex = 4;
            this.bt_start_unfollow_bot.Text = "Start";
            this.bt_start_unfollow_bot.UseVisualStyleBackColor = false;
            this.bt_start_unfollow_bot.Click += new System.EventHandler(this.bt_start_unfollow_bot_Click);
            // 
            // unfollow_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(686, 548);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "unfollow_form";
            this.Text = "unfollow_form";
            this.Load += new System.EventHandler(this.unfollow_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pn_description.ResumeLayout(false);
            this.pn_description.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pn_options.ResumeLayout(false);
            this.pn_options.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.pn_controls.ResumeLayout(false);
            this.pn_console.ResumeLayout(false);
            this.pn_console.PerformLayout();
            this.pn_controls_status.ResumeLayout(false);
            this.pn_controls_status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pn_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pn_options;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_delay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pn_controls;
        private System.Windows.Forms.Panel pn_console;
        private System.Windows.Forms.TextBox tx_console;
        private System.Windows.Forms.Panel pn_controls_status;
        private System.Windows.Forms.Button bt_stop_unfollow_bot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pn_status;
        private System.Windows.Forms.Button bt_start_unfollow_bot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_manage_lists;
        private System.Windows.Forms.ListBox listBox_files;
    }
}
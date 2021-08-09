
namespace InstaMacBot.DesktopInterface
{
    partial class comments_barrage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comments_barrage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pn_description = new System.Windows.Forms.Panel();
            this.lb_description = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pn_options = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_comment_content = new System.Windows.Forms.TextBox();
            this.tx_target_post_link = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nm_delay = new System.Windows.Forms.NumericUpDown();
            this.nm_limit_of_comments = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pn_controls = new System.Windows.Forms.Panel();
            this.pn_console = new System.Windows.Forms.Panel();
            this.tx_console = new System.Windows.Forms.TextBox();
            this.pn_controls_status = new System.Windows.Forms.Panel();
            this.bt_stop_like_follow_bot = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pn_status = new System.Windows.Forms.Panel();
            this.bt_comments_barrage_bot = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pn_description.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pn_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_limit_of_comments)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(711, 587);
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
            this.tabPage1.Size = new System.Drawing.Size(703, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Description";
            // 
            // pn_description
            // 
            this.pn_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_description.Controls.Add(this.lb_description);
            this.pn_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_description.Location = new System.Drawing.Point(2, 3);
            this.pn_description.Name = "pn_description";
            this.pn_description.Size = new System.Drawing.Size(699, 552);
            this.pn_description.TabIndex = 0;
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.Location = new System.Drawing.Point(0, 0);
            this.lb_description.MaximumSize = new System.Drawing.Size(683, 0);
            this.lb_description.Name = "lb_description";
            this.lb_description.Padding = new System.Windows.Forms.Padding(2);
            this.lb_description.Size = new System.Drawing.Size(683, 292);
            this.lb_description.TabIndex = 2;
            this.lb_description.Text = resources.GetString("lb_description.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.tabPage2.Controls.Add(this.pn_options);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(703, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            // 
            // pn_options
            // 
            this.pn_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_options.Controls.Add(this.label4);
            this.pn_options.Controls.Add(this.tx_comment_content);
            this.pn_options.Controls.Add(this.tx_target_post_link);
            this.pn_options.Controls.Add(this.label1);
            this.pn_options.Controls.Add(this.nm_delay);
            this.pn_options.Controls.Add(this.nm_limit_of_comments);
            this.pn_options.Controls.Add(this.label6);
            this.pn_options.Controls.Add(this.label3);
            this.pn_options.Controls.Add(this.label2);
            this.pn_options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_options.Location = new System.Drawing.Point(2, 3);
            this.pn_options.Name = "pn_options";
            this.pn_options.Size = new System.Drawing.Size(699, 552);
            this.pn_options.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "content of the comment";
            // 
            // tx_comment_content
            // 
            this.tx_comment_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.tx_comment_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_comment_content.ForeColor = System.Drawing.Color.White;
            this.tx_comment_content.Location = new System.Drawing.Point(8, 189);
            this.tx_comment_content.Multiline = true;
            this.tx_comment_content.Name = "tx_comment_content";
            this.tx_comment_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_comment_content.Size = new System.Drawing.Size(621, 110);
            this.tx_comment_content.TabIndex = 33;
            // 
            // tx_target_post_link
            // 
            this.tx_target_post_link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.tx_target_post_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_target_post_link.ForeColor = System.Drawing.Color.White;
            this.tx_target_post_link.Location = new System.Drawing.Point(8, 130);
            this.tx_target_post_link.Name = "tx_target_post_link";
            this.tx_target_post_link.Size = new System.Drawing.Size(358, 26);
            this.tx_target_post_link.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "link of the post to comment";
            // 
            // nm_delay
            // 
            this.nm_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.nm_delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_delay.ForeColor = System.Drawing.Color.White;
            this.nm_delay.Location = new System.Drawing.Point(8, 66);
            this.nm_delay.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nm_delay.Name = "nm_delay";
            this.nm_delay.Size = new System.Drawing.Size(70, 26);
            this.nm_delay.TabIndex = 30;
            this.nm_delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_delay.ValueChanged += new System.EventHandler(this.nm_delay_ValueChanged);
            // 
            // nm_limit_of_comments
            // 
            this.nm_limit_of_comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.nm_limit_of_comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_limit_of_comments.ForeColor = System.Drawing.Color.White;
            this.nm_limit_of_comments.Location = new System.Drawing.Point(8, 34);
            this.nm_limit_of_comments.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nm_limit_of_comments.Name = "nm_limit_of_comments";
            this.nm_limit_of_comments.Size = new System.Drawing.Size(70, 26);
            this.nm_limit_of_comments.TabIndex = 29;
            this.nm_limit_of_comments.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nm_limit_of_comments.ValueChanged += new System.EventHandler(this.nm_limit_of_comments_ValueChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delay between each comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of comments (if 0 bot will continue to comment)";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.tabPage3.Controls.Add(this.pn_controls);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage3.Size = new System.Drawing.Size(703, 558);
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
            this.pn_controls.Size = new System.Drawing.Size(699, 552);
            this.pn_controls.TabIndex = 2;
            // 
            // pn_console
            // 
            this.pn_console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pn_console.Controls.Add(this.tx_console);
            this.pn_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_console.Location = new System.Drawing.Point(5, 128);
            this.pn_console.Name = "pn_console";
            this.pn_console.Size = new System.Drawing.Size(689, 419);
            this.pn_console.TabIndex = 8;
            // 
            // tx_console
            // 
            this.tx_console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.tx_console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tx_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_console.ForeColor = System.Drawing.Color.White;
            this.tx_console.Location = new System.Drawing.Point(0, 0);
            this.tx_console.Multiline = true;
            this.tx_console.Name = "tx_console";
            this.tx_console.ReadOnly = true;
            this.tx_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_console.Size = new System.Drawing.Size(689, 419);
            this.tx_console.TabIndex = 7;
            // 
            // pn_controls_status
            // 
            this.pn_controls_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pn_controls_status.Controls.Add(this.bt_stop_like_follow_bot);
            this.pn_controls_status.Controls.Add(this.label5);
            this.pn_controls_status.Controls.Add(this.pn_status);
            this.pn_controls_status.Controls.Add(this.bt_comments_barrage_bot);
            this.pn_controls_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_controls_status.Location = new System.Drawing.Point(5, 0);
            this.pn_controls_status.Name = "pn_controls_status";
            this.pn_controls_status.Size = new System.Drawing.Size(689, 128);
            this.pn_controls_status.TabIndex = 7;
            // 
            // bt_stop_like_follow_bot
            // 
            this.bt_stop_like_follow_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bt_stop_like_follow_bot.FlatAppearance.BorderSize = 0;
            this.bt_stop_like_follow_bot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_stop_like_follow_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stop_like_follow_bot.Location = new System.Drawing.Point(77, 47);
            this.bt_stop_like_follow_bot.Name = "bt_stop_like_follow_bot";
            this.bt_stop_like_follow_bot.Size = new System.Drawing.Size(65, 31);
            this.bt_stop_like_follow_bot.TabIndex = 7;
            this.bt_stop_like_follow_bot.Text = "Stop";
            this.bt_stop_like_follow_bot.UseVisualStyleBackColor = false;
            this.bt_stop_like_follow_bot.Click += new System.EventHandler(this.bt_stop_like_follow_bot_Click);
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
            // bt_comments_barrage_bot
            // 
            this.bt_comments_barrage_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(150)))), ((int)(((byte)(72)))));
            this.bt_comments_barrage_bot.FlatAppearance.BorderSize = 0;
            this.bt_comments_barrage_bot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_comments_barrage_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_comments_barrage_bot.Location = new System.Drawing.Point(3, 47);
            this.bt_comments_barrage_bot.Name = "bt_comments_barrage_bot";
            this.bt_comments_barrage_bot.Size = new System.Drawing.Size(65, 31);
            this.bt_comments_barrage_bot.TabIndex = 4;
            this.bt_comments_barrage_bot.Text = "Start";
            this.bt_comments_barrage_bot.UseVisualStyleBackColor = false;
            this.bt_comments_barrage_bot.Click += new System.EventHandler(this.bt_comments_barrage_bot_Click);
            // 
            // comments_barrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(711, 587);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "comments_barrage";
            this.Text = "comments barrage";
            this.Load += new System.EventHandler(this.comments_barrage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pn_description.ResumeLayout(false);
            this.pn_description.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pn_options.ResumeLayout(false);
            this.pn_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_limit_of_comments)).EndInit();
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
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pn_options;
        private System.Windows.Forms.NumericUpDown nm_delay;
        private System.Windows.Forms.NumericUpDown nm_limit_of_comments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pn_controls;
        private System.Windows.Forms.Panel pn_console;
        private System.Windows.Forms.TextBox tx_console;
        private System.Windows.Forms.Panel pn_controls_status;
        private System.Windows.Forms.Button bt_stop_like_follow_bot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pn_status;
        private System.Windows.Forms.Button bt_comments_barrage_bot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_target_post_link;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_comment_content;
    }
}
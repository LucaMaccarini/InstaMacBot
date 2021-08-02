
namespace InstaMacBot.DesktopInterface
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_session = new System.Windows.Forms.Button();
            this.bt_2factor = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.pn1 = new System.Windows.Forms.Panel();
            this.pn_container_fill_form = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 116);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "InstaMacBot";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.bt_session);
            this.panel2.Controls.Add(this.bt_2factor);
            this.panel2.Controls.Add(this.bt_login);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 116);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(383, 54);
            this.panel2.TabIndex = 1;
            // 
            // bt_session
            // 
            this.bt_session.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_session.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_session.FlatAppearance.BorderSize = 0;
            this.bt_session.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_session.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_session.Location = new System.Drawing.Point(258, 10);
            this.bt_session.Name = "bt_session";
            this.bt_session.Size = new System.Drawing.Size(115, 34);
            this.bt_session.TabIndex = 2;
            this.bt_session.Text = "Load Session";
            this.bt_session.UseVisualStyleBackColor = false;
            this.bt_session.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // bt_2factor
            // 
            this.bt_2factor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_2factor.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_2factor.FlatAppearance.BorderSize = 0;
            this.bt_2factor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_2factor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_2factor.Location = new System.Drawing.Point(84, 10);
            this.bt_2factor.Name = "bt_2factor";
            this.bt_2factor.Size = new System.Drawing.Size(84, 34);
            this.bt_2factor.TabIndex = 1;
            this.bt_2factor.Text = "2 factors";
            this.bt_2factor.UseVisualStyleBackColor = false;
            this.bt_2factor.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.bt_login.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.White;
            this.bt_login.Location = new System.Drawing.Point(10, 10);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(74, 34);
            this.bt_login.TabIndex = 0;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.pn_container_fill_form);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn1.Location = new System.Drawing.Point(10, 170);
            this.pn1.Name = "pn1";
            this.pn1.Padding = new System.Windows.Forms.Padding(10, 30, 10, 0);
            this.pn1.Size = new System.Drawing.Size(383, 337);
            this.pn1.TabIndex = 2;
            // 
            // pn_container_fill_form
            // 
            this.pn_container_fill_form.BackColor = System.Drawing.Color.Transparent;
            this.pn_container_fill_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_container_fill_form.Location = new System.Drawing.Point(10, 30);
            this.pn_container_fill_form.Name = "pn_container_fill_form";
            this.pn_container_fill_form.Size = new System.Drawing.Size(363, 291);
            this.pn_container_fill_form.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(403, 510);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pn1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_2factor;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Panel pn_container_fill_form;
        private System.Windows.Forms.Button bt_session;
    }
}
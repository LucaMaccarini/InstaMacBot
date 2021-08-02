
namespace InstaMacBot.DesktopInterface
{
    partial class load_session_form
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
            this.session_list = new System.Windows.Forms.ListBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.pn_container_fill_form = new System.Windows.Forms.Panel();
            this.pn_container_fill_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // session_list
            // 
            this.session_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.session_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.session_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.session_list.ForeColor = System.Drawing.Color.White;
            this.session_list.FormattingEnabled = true;
            this.session_list.ItemHeight = 18;
            this.session_list.Location = new System.Drawing.Point(10, 10);
            this.session_list.Name = "session_list";
            this.session_list.Size = new System.Drawing.Size(342, 220);
            this.session_list.TabIndex = 0;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(134)))), ((int)(((byte)(89)))));
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.White;
            this.bt_login.Location = new System.Drawing.Point(122, 245);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(117, 34);
            this.bt_login.TabIndex = 3;
            this.bt_login.Text = "Load Session";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // pn_container_fill_form
            // 
            this.pn_container_fill_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_container_fill_form.Controls.Add(this.session_list);
            this.pn_container_fill_form.Controls.Add(this.bt_login);
            this.pn_container_fill_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container_fill_form.Location = new System.Drawing.Point(0, 0);
            this.pn_container_fill_form.Name = "pn_container_fill_form";
            this.pn_container_fill_form.Padding = new System.Windows.Forms.Padding(10);
            this.pn_container_fill_form.Size = new System.Drawing.Size(362, 292);
            this.pn_container_fill_form.TabIndex = 7;
            // 
            // load_session_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(362, 292);
            this.Controls.Add(this.pn_container_fill_form);
            this.DoubleBuffered = true;
            this.Name = "load_session_form";
            this.Text = "load_session_form";
            this.Load += new System.EventHandler(this.load_session_form_Load);
            this.pn_container_fill_form.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox session_list;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Panel pn_container_fill_form;
    }
}

namespace InstaMacBot.DesktopInterface
{
    partial class manage_lists_form
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pn_lists = new System.Windows.Forms.Panel();
            this.pn_controls = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_files = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pn_description = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.pn_lists.SuspendLayout();
            this.pn_controls.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pn_description.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.tabPage2.Controls.Add(this.pn_lists);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(687, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lists";
            // 
            // pn_lists
            // 
            this.pn_lists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_lists.Controls.Add(this.pn_controls);
            this.pn_lists.Controls.Add(this.listBox_files);
            this.pn_lists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_lists.Location = new System.Drawing.Point(2, 3);
            this.pn_lists.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.pn_lists.Name = "pn_lists";
            this.pn_lists.Padding = new System.Windows.Forms.Padding(3);
            this.pn_lists.Size = new System.Drawing.Size(683, 513);
            this.pn_lists.TabIndex = 1;
            // 
            // pn_controls
            // 
            this.pn_controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pn_controls.Controls.Add(this.button2);
            this.pn_controls.Controls.Add(this.button1);
            this.pn_controls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_controls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pn_controls.Location = new System.Drawing.Point(348, 3);
            this.pn_controls.Name = "pn_controls";
            this.pn_controls.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pn_controls.Size = new System.Drawing.Size(199, 507);
            this.pn_controls.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(2, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "delete selected entry";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "refresh list";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_files
            // 
            this.listBox_files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.listBox_files.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_files.ForeColor = System.Drawing.Color.White;
            this.listBox_files.FormattingEnabled = true;
            this.listBox_files.ItemHeight = 20;
            this.listBox_files.Location = new System.Drawing.Point(3, 3);
            this.listBox_files.Name = "listBox_files";
            this.listBox_files.Size = new System.Drawing.Size(345, 507);
            this.listBox_files.TabIndex = 0;
            this.listBox_files.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.tabPage1.Controls.Add(this.pn_description);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(687, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Description";
            // 
            // pn_description
            // 
            this.pn_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_description.Controls.Add(this.label1);
            this.pn_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_description.Location = new System.Drawing.Point(2, 3);
            this.pn_description.Name = "pn_description";
            this.pn_description.Size = new System.Drawing.Size(683, 513);
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
            this.label1.TabIndex = 0;
            this.label1.Text = "bla bla bla";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(85, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 548);
            this.tabControl1.TabIndex = 3;
            // 
            // manage_lists_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(695, 548);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "manage_lists_form";
            this.Text = "manage lists";
            this.Load += new System.EventHandler(this.manage_lists_Load);
            this.tabPage2.ResumeLayout(false);
            this.pn_lists.ResumeLayout(false);
            this.pn_controls.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pn_description.ResumeLayout(false);
            this.pn_description.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pn_lists;
        private System.Windows.Forms.Panel pn_controls;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_files;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pn_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button2;
    }
}

namespace InstaMacBot.MacBotClient_classes
{
    partial class message_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(message_form));
            this.tx_messaggio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.check_link = new System.Windows.Forms.CheckBox();
            this.tx_link = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_messaggio
            // 
            this.tx_messaggio.Location = new System.Drawing.Point(12, 25);
            this.tx_messaggio.Multiline = true;
            this.tx_messaggio.Name = "tx_messaggio";
            this.tx_messaggio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_messaggio.Size = new System.Drawing.Size(293, 389);
            this.tx_messaggio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Use this text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // check_link
            // 
            this.check_link.AutoSize = true;
            this.check_link.Location = new System.Drawing.Point(318, 5);
            this.check_link.Name = "check_link";
            this.check_link.Size = new System.Drawing.Size(117, 17);
            this.check_link.TabIndex = 3;
            this.check_link.Text = "Add a link to send?";
            this.check_link.UseVisualStyleBackColor = true;
            this.check_link.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tx_link
            // 
            this.tx_link.Enabled = false;
            this.tx_link.Location = new System.Drawing.Point(347, 25);
            this.tx_link.Name = "tx_link";
            this.tx_link.Size = new System.Drawing.Size(238, 20);
            this.tx_link.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "link:";
            // 
            // message_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_link);
            this.Controls.Add(this.check_link);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_messaggio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "message_form";
            this.Text = "message_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_messaggio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox check_link;
        private System.Windows.Forms.TextBox tx_link;
        private System.Windows.Forms.Label label2;
    }
}
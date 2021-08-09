
namespace InstaMacBot.DesktopInterface
{
    partial class factor2
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
            this.pn_container_fill_form = new System.Windows.Forms.Panel();
            this.lb_alert = new System.Windows.Forms.Label();
            this.bt_send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_2factorCode = new System.Windows.Forms.TextBox();
            this.pn_container_fill_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_container_fill_form
            // 
            this.pn_container_fill_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_container_fill_form.Controls.Add(this.lb_alert);
            this.pn_container_fill_form.Controls.Add(this.bt_send);
            this.pn_container_fill_form.Controls.Add(this.label2);
            this.pn_container_fill_form.Controls.Add(this.tx_2factorCode);
            this.pn_container_fill_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container_fill_form.Enabled = false;
            this.pn_container_fill_form.Location = new System.Drawing.Point(0, 0);
            this.pn_container_fill_form.Name = "pn_container_fill_form";
            this.pn_container_fill_form.Padding = new System.Windows.Forms.Padding(10);
            this.pn_container_fill_form.Size = new System.Drawing.Size(362, 292);
            this.pn_container_fill_form.TabIndex = 7;
            this.pn_container_fill_form.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_container_fill_form_Paint);
            // 
            // lb_alert
            // 
            this.lb_alert.AutoSize = true;
            this.lb_alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alert.ForeColor = System.Drawing.Color.Black;
            this.lb_alert.Location = new System.Drawing.Point(13, 19);
            this.lb_alert.Name = "lb_alert";
            this.lb_alert.Size = new System.Drawing.Size(286, 20);
            this.lb_alert.TabIndex = 8;
            this.lb_alert.Text = "To unlock this first login with credentials";
            // 
            // bt_send
            // 
            this.bt_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(134)))), ((int)(((byte)(89)))));
            this.bt_send.FlatAppearance.BorderSize = 0;
            this.bt_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_send.ForeColor = System.Drawing.Color.White;
            this.bt_send.Location = new System.Drawing.Point(144, 241);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(74, 34);
            this.bt_send.TabIndex = 7;
            this.bt_send.Text = "Send";
            this.bt_send.UseVisualStyleBackColor = false;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "2 Factor code";
            // 
            // tx_2factorCode
            // 
            this.tx_2factorCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.tx_2factorCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_2factorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_2factorCode.ForeColor = System.Drawing.Color.White;
            this.tx_2factorCode.Location = new System.Drawing.Point(17, 79);
            this.tx_2factorCode.Multiline = true;
            this.tx_2factorCode.Name = "tx_2factorCode";
            this.tx_2factorCode.Size = new System.Drawing.Size(251, 23);
            this.tx_2factorCode.TabIndex = 6;
            // 
            // factor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(362, 292);
            this.Controls.Add(this.pn_container_fill_form);
            this.DoubleBuffered = true;
            this.Name = "factor2";
            this.Text = "2_factor";
            this.Load += new System.EventHandler(this.factor2_Load);
            this.pn_container_fill_form.ResumeLayout(false);
            this.pn_container_fill_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_container_fill_form;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_2factorCode;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.Label lb_alert;
    }
}

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
            this.label2 = new System.Windows.Forms.Label();
            this.pn_container_fill_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_container_fill_form
            // 
            this.pn_container_fill_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_container_fill_form.Controls.Add(this.label2);
            this.pn_container_fill_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container_fill_form.Location = new System.Drawing.Point(0, 0);
            this.pn_container_fill_form.Name = "pn_container_fill_form";
            this.pn_container_fill_form.Padding = new System.Windows.Forms.Padding(10);
            this.pn_container_fill_form.Size = new System.Drawing.Size(362, 292);
            this.pn_container_fill_form.TabIndex = 7;
            this.pn_container_fill_form.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_container_fill_form_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(99, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Not avaible";
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
    }
}
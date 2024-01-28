namespace DLWMS.WinForms.IB200106
{
    partial class frmStudentInfo
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
            this.picSlika = new System.Windows.Forms.PictureBox();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // picSlika
            // 
            this.picSlika.Location = new System.Drawing.Point(12, 12);
            this.picSlika.Name = "picSlika";
            this.picSlika.Size = new System.Drawing.Size(370, 368);
            this.picSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlika.TabIndex = 0;
            this.picSlika.TabStop = false;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImePrezime.Location = new System.Drawing.Point(112, 383);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(177, 37);
            this.lblImePrezime.TabIndex = 1;
            this.lblImePrezime.Text = "Ime Prezime";
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(159, 432);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(79, 20);
            this.lblProsjek.TabIndex = 2;
            this.lblProsjek.Text = "Prosjek: 10";
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 471);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.picSlika);
            this.Name = "frmStudentInfo";
            this.Text = "frmStudentInfo";
            this.Load += new System.EventHandler(this.frmStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picSlika;
        private Label lblImePrezime;
        private Label lblProsjek;
    }
}
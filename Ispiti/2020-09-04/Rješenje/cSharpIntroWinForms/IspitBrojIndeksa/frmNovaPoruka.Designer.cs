
namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    partial class frmNovaPoruka
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
            this.lblPrimalac = new System.Windows.Forms.Label();
            this.txtPrimalac = new System.Windows.Forms.TextBox();
            this.lblSadrzaj = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.lblSlika = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.picSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrimalac
            // 
            this.lblPrimalac.AutoSize = true;
            this.lblPrimalac.Location = new System.Drawing.Point(12, 9);
            this.lblPrimalac.Name = "lblPrimalac";
            this.lblPrimalac.Size = new System.Drawing.Size(66, 17);
            this.lblPrimalac.TabIndex = 0;
            this.lblPrimalac.Text = "Primalac:";
            // 
            // txtPrimalac
            // 
            this.txtPrimalac.Enabled = false;
            this.txtPrimalac.Location = new System.Drawing.Point(12, 29);
            this.txtPrimalac.Name = "txtPrimalac";
            this.txtPrimalac.ReadOnly = true;
            this.txtPrimalac.Size = new System.Drawing.Size(294, 22);
            this.txtPrimalac.TabIndex = 1;
            // 
            // lblSadrzaj
            // 
            this.lblSadrzaj.AutoSize = true;
            this.lblSadrzaj.Location = new System.Drawing.Point(9, 54);
            this.lblSadrzaj.Name = "lblSadrzaj";
            this.lblSadrzaj.Size = new System.Drawing.Size(60, 17);
            this.lblSadrzaj.TabIndex = 2;
            this.lblSadrzaj.Text = "Sadržaj:";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(12, 74);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(294, 290);
            this.txtSadrzaj.TabIndex = 3;
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Location = new System.Drawing.Point(312, 9);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(42, 17);
            this.lblSlika.TabIndex = 4;
            this.lblSlika.Text = "Slika:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(493, 370);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(78, 32);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // picSlika
            // 
            this.picSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSlika.Location = new System.Drawing.Point(315, 29);
            this.picSlika.Name = "picSlika";
            this.picSlika.Size = new System.Drawing.Size(256, 335);
            this.picSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlika.TabIndex = 5;
            this.picSlika.TabStop = false;
            this.picSlika.DoubleClick += new System.EventHandler(this.picSlika_DoubleClick);
            // 
            // frmNovaPoruka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 409);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.picSlika);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.lblSadrzaj);
            this.Controls.Add(this.txtPrimalac);
            this.Controls.Add(this.lblPrimalac);
            this.Name = "frmNovaPoruka";
            this.Text = "Nova poruka";
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimalac;
        private System.Windows.Forms.TextBox txtPrimalac;
        private System.Windows.Forms.Label lblSadrzaj;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.PictureBox picSlika;
        private System.Windows.Forms.Button btnSpremi;
    }
}
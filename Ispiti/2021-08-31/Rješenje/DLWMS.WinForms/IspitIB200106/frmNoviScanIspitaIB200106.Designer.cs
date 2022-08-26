
namespace DLWMS.WinForms.IspitIB200106
{
    partial class frmNoviScanIspitaIB200106
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
            this.lblPredmet = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.lblSlika = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.chkVaranje = new System.Windows.Forms.CheckBox();
            this.picSlika = new System.Windows.Forms.PictureBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Location = new System.Drawing.Point(12, 9);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(65, 17);
            this.lblPredmet.TabIndex = 0;
            this.lblPredmet.Text = "Predmet:";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(12, 56);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(81, 17);
            this.lblNapomena.TabIndex = 1;
            this.lblNapomena.Text = "Napomena:";
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Location = new System.Drawing.Point(338, 9);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(42, 17);
            this.lblSlika.TabIndex = 2;
            this.lblSlika.Text = "Slika:";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(15, 29);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(317, 24);
            this.cmbPredmeti.TabIndex = 3;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(15, 76);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(317, 307);
            this.txtNapomena.TabIndex = 4;
            // 
            // chkVaranje
            // 
            this.chkVaranje.AutoSize = true;
            this.chkVaranje.Location = new System.Drawing.Point(15, 396);
            this.chkVaranje.Name = "chkVaranje";
            this.chkVaranje.Size = new System.Drawing.Size(136, 21);
            this.chkVaranje.TabIndex = 5;
            this.chkVaranje.Text = "Varanje na ispitu";
            this.chkVaranje.UseVisualStyleBackColor = true;
            // 
            // picSlika
            // 
            this.picSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSlika.Location = new System.Drawing.Point(341, 29);
            this.picSlika.Name = "picSlika";
            this.picSlika.Size = new System.Drawing.Size(319, 354);
            this.picSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlika.TabIndex = 6;
            this.picSlika.TabStop = false;
            this.picSlika.DoubleClick += new System.EventHandler(this.picSlika_DoubleClick);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(586, 389);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(74, 32);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // frmNoviScanIspitaIB200106
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 429);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.picSlika);
            this.Controls.Add(this.chkVaranje);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblPredmet);
            this.Name = "frmNoviScanIspitaIB200106";
            this.Text = "Scan ispita";
            this.Load += new System.EventHandler(this.frmNoviScanIspitaIB200106_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.CheckBox chkVaranje;
        private System.Windows.Forms.PictureBox picSlika;
        private System.Windows.Forms.Button btnSpremi;
    }
}
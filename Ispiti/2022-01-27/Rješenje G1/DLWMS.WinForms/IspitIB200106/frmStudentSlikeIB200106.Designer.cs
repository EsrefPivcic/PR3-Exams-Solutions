
namespace DLWMS.WinForms.IspitIB200106
{
    partial class frmStudentSlikeIB200106
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
            this.lblSlika = new System.Windows.Forms.Label();
            this.lblNoviOpis = new System.Windows.Forms.Label();
            this.picNovaSlika = new System.Windows.Forms.PictureBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.grpPregled = new System.Windows.Forms.GroupBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.picSlika = new System.Windows.Forms.PictureBox();
            this.lblBrojac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNovaSlika)).BeginInit();
            this.grpPregled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Location = new System.Drawing.Point(9, 9);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(42, 17);
            this.lblSlika.TabIndex = 0;
            this.lblSlika.Text = "Slika:";
            // 
            // lblNoviOpis
            // 
            this.lblNoviOpis.AutoSize = true;
            this.lblNoviOpis.Location = new System.Drawing.Point(196, 9);
            this.lblNoviOpis.Name = "lblNoviOpis";
            this.lblNoviOpis.Size = new System.Drawing.Size(41, 17);
            this.lblNoviOpis.TabIndex = 1;
            this.lblNoviOpis.Text = "Opis:";
            // 
            // picNovaSlika
            // 
            this.picNovaSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNovaSlika.Location = new System.Drawing.Point(12, 29);
            this.picNovaSlika.Name = "picNovaSlika";
            this.picNovaSlika.Size = new System.Drawing.Size(178, 185);
            this.picNovaSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNovaSlika.TabIndex = 2;
            this.picNovaSlika.TabStop = false;
            this.picNovaSlika.DoubleClick += new System.EventHandler(this.picNovaSlika_DoubleClick);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(199, 29);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(358, 145);
            this.txtOpis.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(460, 180);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(97, 34);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj sliku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // grpPregled
            // 
            this.grpPregled.Controls.Add(this.lblOpis);
            this.grpPregled.Controls.Add(this.lblDatum);
            this.grpPregled.Controls.Add(this.btnBack);
            this.grpPregled.Controls.Add(this.btnNext);
            this.grpPregled.Controls.Add(this.picSlika);
            this.grpPregled.Controls.Add(this.lblBrojac);
            this.grpPregled.Location = new System.Drawing.Point(12, 220);
            this.grpPregled.Name = "grpPregled";
            this.grpPregled.Size = new System.Drawing.Size(545, 441);
            this.grpPregled.TabIndex = 5;
            this.grpPregled.TabStop = false;
            this.grpPregled.Text = "Pregled slika";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(108, 414);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(0, 17);
            this.lblOpis.TabIndex = 5;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(108, 385);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 17);
            this.lblDatum.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 200);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<==";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(451, 200);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 35);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "==>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // picSlika
            // 
            this.picSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSlika.Location = new System.Drawing.Point(111, 62);
            this.picSlika.Name = "picSlika";
            this.picSlika.Size = new System.Drawing.Size(323, 320);
            this.picSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlika.TabIndex = 1;
            this.picSlika.TabStop = false;
            // 
            // lblBrojac
            // 
            this.lblBrojac.AutoSize = true;
            this.lblBrojac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojac.Location = new System.Drawing.Point(208, 18);
            this.lblBrojac.Name = "lblBrojac";
            this.lblBrojac.Size = new System.Drawing.Size(74, 29);
            this.lblBrojac.TabIndex = 0;
            this.lblBrojac.Text = "Slika";
            // 
            // frmStudentSlikeIB200106
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 673);
            this.Controls.Add(this.grpPregled);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.picNovaSlika);
            this.Controls.Add(this.lblNoviOpis);
            this.Controls.Add(this.lblSlika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmStudentSlikeIB200106";
            this.Text = "Slike studenta";
            this.Load += new System.EventHandler(this.frmStudentSlikeIB200106_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNovaSlika)).EndInit();
            this.grpPregled.ResumeLayout(false);
            this.grpPregled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.Label lblNoviOpis;
        private System.Windows.Forms.PictureBox picNovaSlika;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox grpPregled;
        private System.Windows.Forms.PictureBox picSlika;
        private System.Windows.Forms.Label lblBrojac;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOpis;
    }
}
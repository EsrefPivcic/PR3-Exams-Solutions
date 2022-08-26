
namespace DLWMS.WinForms.IspitIB200106
{
    partial class frmStudentSeminraskiIB200106
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.grpNovaSlika = new System.Windows.Forms.GroupBox();
            this.lblSlika = new System.Windows.Forms.Label();
            this.lblNoviOpis = new System.Windows.Forms.Label();
            this.picNovaSlika = new System.Windows.Forms.PictureBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.grpPregled = new System.Windows.Forms.GroupBox();
            this.lblBrojac = new System.Windows.Forms.Label();
            this.picSlika = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.grpNovaSlika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNovaSlika)).BeginInit();
            this.grpPregled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(193, 9);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(115, 31);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student";
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmet.Location = new System.Drawing.Point(193, 49);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(123, 31);
            this.lblPredmet.TabIndex = 1;
            this.lblPredmet.Text = "Predmet";
            // 
            // grpNovaSlika
            // 
            this.grpNovaSlika.Controls.Add(this.btnDodaj);
            this.grpNovaSlika.Controls.Add(this.txtOpis);
            this.grpNovaSlika.Controls.Add(this.picNovaSlika);
            this.grpNovaSlika.Controls.Add(this.lblNoviOpis);
            this.grpNovaSlika.Controls.Add(this.lblSlika);
            this.grpNovaSlika.Location = new System.Drawing.Point(12, 83);
            this.grpNovaSlika.Name = "grpNovaSlika";
            this.grpNovaSlika.Size = new System.Drawing.Size(544, 193);
            this.grpNovaSlika.TabIndex = 2;
            this.grpNovaSlika.TabStop = false;
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Location = new System.Drawing.Point(6, 18);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(42, 17);
            this.lblSlika.TabIndex = 0;
            this.lblSlika.Text = "Slika:";
            // 
            // lblNoviOpis
            // 
            this.lblNoviOpis.AutoSize = true;
            this.lblNoviOpis.Location = new System.Drawing.Point(163, 18);
            this.lblNoviOpis.Name = "lblNoviOpis";
            this.lblNoviOpis.Size = new System.Drawing.Size(41, 17);
            this.lblNoviOpis.TabIndex = 1;
            this.lblNoviOpis.Text = "Opis:";
            // 
            // picNovaSlika
            // 
            this.picNovaSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNovaSlika.Location = new System.Drawing.Point(9, 38);
            this.picNovaSlika.Name = "picNovaSlika";
            this.picNovaSlika.Size = new System.Drawing.Size(148, 149);
            this.picNovaSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNovaSlika.TabIndex = 2;
            this.picNovaSlika.TabStop = false;
            this.picNovaSlika.Click += new System.EventHandler(this.picNovaSlika_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(166, 38);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(372, 111);
            this.txtOpis.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(448, 155);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(90, 32);
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
            this.grpPregled.Location = new System.Drawing.Point(21, 282);
            this.grpPregled.Name = "grpPregled";
            this.grpPregled.Size = new System.Drawing.Size(535, 438);
            this.grpPregled.TabIndex = 3;
            this.grpPregled.TabStop = false;
            this.grpPregled.Text = "Pregled seminraskog";
            // 
            // lblBrojac
            // 
            this.lblBrojac.AutoSize = true;
            this.lblBrojac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojac.Location = new System.Drawing.Point(193, 30);
            this.lblBrojac.Name = "lblBrojac";
            this.lblBrojac.Size = new System.Drawing.Size(108, 29);
            this.lblBrojac.TabIndex = 4;
            this.lblBrojac.Text = "Stranica";
            // 
            // picSlika
            // 
            this.picSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSlika.Location = new System.Drawing.Point(128, 62);
            this.picSlika.Name = "picSlika";
            this.picSlika.Size = new System.Drawing.Size(273, 293);
            this.picSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlika.TabIndex = 5;
            this.picSlika.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(428, 199);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 30);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "==>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(28, 199);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<==";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(125, 358);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 17);
            this.lblDatum.TabIndex = 8;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(125, 375);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(0, 17);
            this.lblOpis.TabIndex = 9;
            // 
            // frmStudentSeminraskiIB200106
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 732);
            this.Controls.Add(this.grpPregled);
            this.Controls.Add(this.grpNovaSlika);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.lblStudent);
            this.Name = "frmStudentSeminraskiIB200106";
            this.Text = "Seminraski";
            this.Load += new System.EventHandler(this.frmStudentSeminraskiIB200106_Load);
            this.grpNovaSlika.ResumeLayout(false);
            this.grpNovaSlika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNovaSlika)).EndInit();
            this.grpPregled.ResumeLayout(false);
            this.grpPregled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.GroupBox grpNovaSlika;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.PictureBox picNovaSlika;
        private System.Windows.Forms.Label lblNoviOpis;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.GroupBox grpPregled;
        private System.Windows.Forms.PictureBox picSlika;
        private System.Windows.Forms.Label lblBrojac;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
    }
}
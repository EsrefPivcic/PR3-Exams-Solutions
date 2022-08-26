
namespace DLWMS.WinForms.IspitBrojIndeksa
{
    partial class frmCovidTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.cmbRezultat = new System.Windows.Forms.ComboBox();
            this.chkDostavljen = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvTestovi = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NalazDostavljen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblBroj = new System.Windows.Forms.Label();
            this.grpGenerisanjeTestova = new System.Windows.Forms.GroupBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.txtBrojTestova = new System.Windows.Forms.TextBox();
            this.lblBrojTestova = new System.Windows.Forms.Label();
            this.grpBrisanje = new System.Windows.Forms.GroupBox();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestovi)).BeginInit();
            this.grpGenerisanjeTestova.SuspendLayout();
            this.grpBrisanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.Location = new System.Drawing.Point(12, 29);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(227, 24);
            this.cmbStudenti.TabIndex = 1;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(242, 9);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(115, 17);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum testiranja:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(245, 30);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 3;
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(453, 9);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(99, 17);
            this.lblRezultat.TabIndex = 4;
            this.lblRezultat.Text = "Rezultat testa:";
            // 
            // cmbRezultat
            // 
            this.cmbRezultat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRezultat.FormattingEnabled = true;
            this.cmbRezultat.Items.AddRange(new object[] {
            "Negativan",
            "Pozitivan"});
            this.cmbRezultat.Location = new System.Drawing.Point(456, 29);
            this.cmbRezultat.Name = "cmbRezultat";
            this.cmbRezultat.Size = new System.Drawing.Size(121, 24);
            this.cmbRezultat.TabIndex = 5;
            // 
            // chkDostavljen
            // 
            this.chkDostavljen.AutoSize = true;
            this.chkDostavljen.Location = new System.Drawing.Point(583, 31);
            this.chkDostavljen.Name = "chkDostavljen";
            this.chkDostavljen.Size = new System.Drawing.Size(134, 21);
            this.chkDostavljen.TabIndex = 6;
            this.chkDostavljen.Text = "Nalaz dostavljen";
            this.chkDostavljen.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(723, 26);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 29);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvTestovi
            // 
            this.dgvTestovi.AllowUserToAddRows = false;
            this.dgvTestovi.AllowUserToDeleteRows = false;
            this.dgvTestovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Rezultat,
            this.NalazDostavljen});
            this.dgvTestovi.Location = new System.Drawing.Point(12, 59);
            this.dgvTestovi.Name = "dgvTestovi";
            this.dgvTestovi.ReadOnly = true;
            this.dgvTestovi.RowHeadersWidth = 51;
            this.dgvTestovi.RowTemplate.Height = 24;
            this.dgvTestovi.Size = new System.Drawing.Size(786, 281);
            this.dgvTestovi.TabIndex = 8;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Rezultat
            // 
            this.Rezultat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rezultat.DataPropertyName = "Rezultat";
            this.Rezultat.HeaderText = "Rezultat";
            this.Rezultat.MinimumWidth = 6;
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.ReadOnly = true;
            // 
            // NalazDostavljen
            // 
            this.NalazDostavljen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NalazDostavljen.DataPropertyName = "NalazDostavljen";
            this.NalazDostavljen.HeaderText = "Nalaz dostavljen";
            this.NalazDostavljen.MinimumWidth = 6;
            this.NalazDostavljen.Name = "NalazDostavljen";
            this.NalazDostavljen.ReadOnly = true;
            this.NalazDostavljen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NalazDostavljen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(13, 347);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(87, 17);
            this.lblBroj.TabIndex = 9;
            this.lblBroj.Text = "Broj testova:";
            // 
            // grpGenerisanjeTestova
            // 
            this.grpGenerisanjeTestova.Controls.Add(this.btnGenerisi);
            this.grpGenerisanjeTestova.Controls.Add(this.txtBrojTestova);
            this.grpGenerisanjeTestova.Controls.Add(this.lblBrojTestova);
            this.grpGenerisanjeTestova.Location = new System.Drawing.Point(135, 347);
            this.grpGenerisanjeTestova.Name = "grpGenerisanjeTestova";
            this.grpGenerisanjeTestova.Size = new System.Drawing.Size(345, 90);
            this.grpGenerisanjeTestova.TabIndex = 10;
            this.grpGenerisanjeTestova.TabStop = false;
            this.grpGenerisanjeTestova.Text = "Generisanje testova:";
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(246, 35);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(93, 32);
            this.btnGenerisi.TabIndex = 12;
            this.btnGenerisi.Text = "Generiši";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // txtBrojTestova
            // 
            this.txtBrojTestova.Location = new System.Drawing.Point(99, 40);
            this.txtBrojTestova.Name = "txtBrojTestova";
            this.txtBrojTestova.Size = new System.Drawing.Size(141, 22);
            this.txtBrojTestova.TabIndex = 11;
            // 
            // lblBrojTestova
            // 
            this.lblBrojTestova.AutoSize = true;
            this.lblBrojTestova.Location = new System.Drawing.Point(6, 43);
            this.lblBrojTestova.Name = "lblBrojTestova";
            this.lblBrojTestova.Size = new System.Drawing.Size(87, 17);
            this.lblBrojTestova.TabIndex = 0;
            this.lblBrojTestova.Text = "Broj testova:";
            // 
            // grpBrisanje
            // 
            this.grpBrisanje.Controls.Add(this.btnBrisi);
            this.grpBrisanje.Location = new System.Drawing.Point(486, 347);
            this.grpBrisanje.Name = "grpBrisanje";
            this.grpBrisanje.Size = new System.Drawing.Size(200, 90);
            this.grpBrisanje.TabIndex = 11;
            this.grpBrisanje.TabStop = false;
            this.grpBrisanje.Text = "Brisanje testova:";
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(17, 31);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(164, 41);
            this.btnBrisi.TabIndex = 0;
            this.btnBrisi.Text = "OBRIŠI TESTOVE";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(710, 382);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 32);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Printaj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmCovidTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 449);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grpBrisanje);
            this.Controls.Add(this.grpGenerisanjeTestova);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.dgvTestovi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.chkDostavljen);
            this.Controls.Add(this.cmbRezultat);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.cmbStudenti);
            this.Controls.Add(this.label1);
            this.Name = "frmCovidTest";
            this.Text = "Rezultati COVID testiranja";
            this.Load += new System.EventHandler(this.frmCovidTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestovi)).EndInit();
            this.grpGenerisanjeTestova.ResumeLayout(false);
            this.grpGenerisanjeTestova.PerformLayout();
            this.grpBrisanje.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.ComboBox cmbRezultat;
        private System.Windows.Forms.CheckBox chkDostavljen;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvTestovi;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.GroupBox grpGenerisanjeTestova;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.TextBox txtBrojTestova;
        private System.Windows.Forms.Label lblBrojTestova;
        private System.Windows.Forms.GroupBox grpBrisanje;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezultat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NalazDostavljen;
    }
}

namespace DLWMS.WinForms.IspitIB200106
{
    partial class Pretraga
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
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.lblNajveci = new System.Windows.Forms.Label();
            this.grpThreading = new System.Windows.Forms.GroupBox();
            this.btnGenerisiInfo = new System.Windows.Forms.Button();
            this.lblZnakovi = new System.Windows.Forms.Label();
            this.lblSuglasnici = new System.Windows.Forms.Label();
            this.lblSamoglasnici = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.lblUnosSadrzaja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.grpThreading.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(9, 15);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(101, 17);
            this.lblImePrezime.TabIndex = 0;
            this.lblImePrezime.Text = "Ime ili prezime:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(116, 12);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(830, 22);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Polozeni,
            this.BrojPolozenih,
            this.Prosjek,
            this.Ispiti});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 40);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.Size = new System.Drawing.Size(934, 273);
            this.dgvStudenti.TabIndex = 2;
            this.dgvStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // Polozeni
            // 
            this.Polozeni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Polozeni.DataPropertyName = "Polozeni";
            this.Polozeni.HeaderText = "Položeni predmeti";
            this.Polozeni.MinimumWidth = 6;
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.ReadOnly = true;
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPolozenih.DataPropertyName = "BrojPolozenih";
            this.BrojPolozenih.HeaderText = "Broj položenih";
            this.BrojPolozenih.MinimumWidth = 6;
            this.BrojPolozenih.Name = "BrojPolozenih";
            this.BrojPolozenih.ReadOnly = true;
            // 
            // Prosjek
            // 
            this.Prosjek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.MinimumWidth = 6;
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            // 
            // Ispiti
            // 
            this.Ispiti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ispiti.HeaderText = "";
            this.Ispiti.MinimumWidth = 6;
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.ReadOnly = true;
            this.Ispiti.Text = "Ispiti";
            this.Ispiti.UseColumnTextForButtonValue = true;
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(12, 316);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(174, 17);
            this.lblProsjek.TabIndex = 3;
            this.lblProsjek.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblNajveci
            // 
            this.lblNajveci.AutoSize = true;
            this.lblNajveci.Location = new System.Drawing.Point(632, 316);
            this.lblNajveci.Name = "lblNajveci";
            this.lblNajveci.Size = new System.Drawing.Size(162, 17);
            this.lblNajveci.TabIndex = 4;
            this.lblNajveci.Text = "Najveći prosjek ostvario:";
            // 
            // grpThreading
            // 
            this.grpThreading.Controls.Add(this.btnGenerisiInfo);
            this.grpThreading.Controls.Add(this.lblZnakovi);
            this.grpThreading.Controls.Add(this.lblSuglasnici);
            this.grpThreading.Controls.Add(this.lblSamoglasnici);
            this.grpThreading.Controls.Add(this.lblInfo);
            this.grpThreading.Controls.Add(this.txtSadrzaj);
            this.grpThreading.Controls.Add(this.lblUnosSadrzaja);
            this.grpThreading.Location = new System.Drawing.Point(15, 336);
            this.grpThreading.Name = "grpThreading";
            this.grpThreading.Size = new System.Drawing.Size(931, 209);
            this.grpThreading.TabIndex = 6;
            this.grpThreading.TabStop = false;
            this.grpThreading.Text = "Threading";
            // 
            // btnGenerisiInfo
            // 
            this.btnGenerisiInfo.Location = new System.Drawing.Point(791, 142);
            this.btnGenerisiInfo.Name = "btnGenerisiInfo";
            this.btnGenerisiInfo.Size = new System.Drawing.Size(134, 34);
            this.btnGenerisiInfo.TabIndex = 6;
            this.btnGenerisiInfo.Text = "Generiši info";
            this.btnGenerisiInfo.UseVisualStyleBackColor = true;
            this.btnGenerisiInfo.Click += new System.EventHandler(this.btnGenerisiInfo_Click);
            // 
            // lblZnakovi
            // 
            this.lblZnakovi.AutoSize = true;
            this.lblZnakovi.Location = new System.Drawing.Point(93, 181);
            this.lblZnakovi.Name = "lblZnakovi";
            this.lblZnakovi.Size = new System.Drawing.Size(67, 17);
            this.lblZnakovi.TabIndex = 5;
            this.lblZnakovi.Text = "Znakova:";
            // 
            // lblSuglasnici
            // 
            this.lblSuglasnici.AutoSize = true;
            this.lblSuglasnici.Location = new System.Drawing.Point(93, 164);
            this.lblSuglasnici.Name = "lblSuglasnici";
            this.lblSuglasnici.Size = new System.Drawing.Size(81, 17);
            this.lblSuglasnici.TabIndex = 4;
            this.lblSuglasnici.Text = "Suglasnika:";
            // 
            // lblSamoglasnici
            // 
            this.lblSamoglasnici.AutoSize = true;
            this.lblSamoglasnici.Location = new System.Drawing.Point(93, 147);
            this.lblSamoglasnici.Name = "lblSamoglasnici";
            this.lblSamoglasnici.Size = new System.Drawing.Size(100, 17);
            this.lblSamoglasnici.TabIndex = 3;
            this.lblSamoglasnici.Text = "Samoglasnika:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(6, 139);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(87, 17);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Sadržaj info:";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(6, 44);
            this.txtSadrzaj.MaxLength = 100000000;
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSadrzaj.Size = new System.Drawing.Size(919, 92);
            this.txtSadrzaj.TabIndex = 1;
            // 
            // lblUnosSadrzaja
            // 
            this.lblUnosSadrzaja.AutoSize = true;
            this.lblUnosSadrzaja.Location = new System.Drawing.Point(3, 24);
            this.lblUnosSadrzaja.Name = "lblUnosSadrzaja";
            this.lblUnosSadrzaja.Size = new System.Drawing.Size(110, 17);
            this.lblUnosSadrzaja.TabIndex = 0;
            this.lblUnosSadrzaja.Text = "Unesite sadržaj:";
            // 
            // Pretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 555);
            this.Controls.Add(this.grpThreading);
            this.Controls.Add(this.lblNajveci);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblImePrezime);
            this.Name = "Pretraga";
            this.Text = "Pretraga";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.grpThreading.ResumeLayout(false);
            this.grpThreading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label lblNajveci;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polozeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
        private System.Windows.Forms.GroupBox grpThreading;
        private System.Windows.Forms.Button btnGenerisiInfo;
        private System.Windows.Forms.Label lblZnakovi;
        private System.Windows.Forms.Label lblSuglasnici;
        private System.Windows.Forms.Label lblSamoglasnici;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Label lblUnosSadrzaja;
    }
}
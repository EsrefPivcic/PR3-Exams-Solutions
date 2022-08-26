
namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    partial class frmPretraga
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
            this.lblNazivPredmeta = new System.Windows.Forms.Label();
            this.txtNazivPredmeta = new System.Windows.Forms.TextBox();
            this.dgvKorisniciPredmeti = new System.Windows.Forms.DataGridView();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poruke = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.grpThreading = new System.Windows.Forms.GroupBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.btnSumiraj = new System.Windows.Forms.Button();
            this.txtBroj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciPredmeti)).BeginInit();
            this.grpThreading.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNazivPredmeta
            // 
            this.lblNazivPredmeta.AutoSize = true;
            this.lblNazivPredmeta.Location = new System.Drawing.Point(12, 15);
            this.lblNazivPredmeta.Name = "lblNazivPredmeta";
            this.lblNazivPredmeta.Size = new System.Drawing.Size(111, 17);
            this.lblNazivPredmeta.TabIndex = 0;
            this.lblNazivPredmeta.Text = "Naziv predmeta:";
            // 
            // txtNazivPredmeta
            // 
            this.txtNazivPredmeta.Location = new System.Drawing.Point(129, 12);
            this.txtNazivPredmeta.Name = "txtNazivPredmeta";
            this.txtNazivPredmeta.Size = new System.Drawing.Size(655, 22);
            this.txtNazivPredmeta.TabIndex = 1;
            this.txtNazivPredmeta.TextChanged += new System.EventHandler(this.txtNazivPredmeta_TextChanged);
            // 
            // dgvKorisniciPredmeti
            // 
            this.dgvKorisniciPredmeti.AllowUserToAddRows = false;
            this.dgvKorisniciPredmeti.AllowUserToDeleteRows = false;
            this.dgvKorisniciPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisniciPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Korisnik,
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Poruke});
            this.dgvKorisniciPredmeti.Location = new System.Drawing.Point(15, 40);
            this.dgvKorisniciPredmeti.Name = "dgvKorisniciPredmeti";
            this.dgvKorisniciPredmeti.ReadOnly = true;
            this.dgvKorisniciPredmeti.RowHeadersWidth = 51;
            this.dgvKorisniciPredmeti.RowTemplate.Height = 24;
            this.dgvKorisniciPredmeti.Size = new System.Drawing.Size(769, 250);
            this.dgvKorisniciPredmeti.TabIndex = 2;
            this.dgvKorisniciPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisniciPredmeti_CellContentClick);
            // 
            // Korisnik
            // 
            this.Korisnik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Ime i prezime";
            this.Korisnik.MinimumWidth = 6;
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
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
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Poruke
            // 
            this.Poruke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Poruke.HeaderText = "Poruke";
            this.Poruke.MinimumWidth = 6;
            this.Poruke.Name = "Poruke";
            this.Poruke.ReadOnly = true;
            this.Poruke.Text = "Poruke";
            this.Poruke.UseColumnTextForButtonValue = true;
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(12, 293);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(186, 17);
            this.lblProsjek.TabIndex = 3;
            this.lblProsjek.Text = "Prosjek prikazanih ocjena: 0";
            // 
            // grpThreading
            // 
            this.grpThreading.Controls.Add(this.lblSuma);
            this.grpThreading.Controls.Add(this.btnSumiraj);
            this.grpThreading.Controls.Add(this.txtBroj);
            this.grpThreading.Location = new System.Drawing.Point(326, 296);
            this.grpThreading.Name = "grpThreading";
            this.grpThreading.Size = new System.Drawing.Size(458, 160);
            this.grpThreading.TabIndex = 4;
            this.grpThreading.TabStop = false;
            this.grpThreading.Text = "Threading";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(6, 98);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(48, 17);
            this.lblSuma.TabIndex = 2;
            this.lblSuma.Text = "Suma:";
            // 
            // btnSumiraj
            // 
            this.btnSumiraj.Location = new System.Drawing.Point(373, 28);
            this.btnSumiraj.Name = "btnSumiraj";
            this.btnSumiraj.Size = new System.Drawing.Size(79, 30);
            this.btnSumiraj.TabIndex = 1;
            this.btnSumiraj.Text = "Sumiraj";
            this.btnSumiraj.UseVisualStyleBackColor = true;
            this.btnSumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(6, 32);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(361, 22);
            this.txtBroj.TabIndex = 0;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 468);
            this.Controls.Add(this.grpThreading);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.dgvKorisniciPredmeti);
            this.Controls.Add(this.txtNazivPredmeta);
            this.Controls.Add(this.lblNazivPredmeta);
            this.Name = "frmPretraga";
            this.Text = "Pretraga";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciPredmeti)).EndInit();
            this.grpThreading.ResumeLayout(false);
            this.grpThreading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivPredmeta;
        private System.Windows.Forms.TextBox txtNazivPredmeta;
        private System.Windows.Forms.DataGridView dgvKorisniciPredmeti;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.GroupBox grpThreading;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Button btnSumiraj;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Poruke;
    }
}
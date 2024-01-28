namespace DLWMS.WinForms.IB200106
{
    partial class frmUvjerenja
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
            this.btnNoviZahtjev = new System.Windows.Forms.Button();
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uplatnica = new System.Windows.Forms.DataGridViewImageColumn();
            this.Printano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Printaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpThreading = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblBroj = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.lblSvrha = new System.Windows.Forms.Label();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.lblVrsta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.grpThreading.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNoviZahtjev
            // 
            this.btnNoviZahtjev.Location = new System.Drawing.Point(809, 12);
            this.btnNoviZahtjev.Name = "btnNoviZahtjev";
            this.btnNoviZahtjev.Size = new System.Drawing.Size(121, 29);
            this.btnNoviZahtjev.TabIndex = 0;
            this.btnNoviZahtjev.Text = "Novi zahtjev";
            this.btnNoviZahtjev.UseVisualStyleBackColor = true;
            this.btnNoviZahtjev.Click += new System.EventHandler(this.btnNoviZahtjev_Click);
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.AllowUserToAddRows = false;
            this.dgvZahtjevi.AllowUserToDeleteRows = false;
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Vrsta,
            this.Svrha,
            this.Uplatnica,
            this.Printano,
            this.Brisi,
            this.Printaj});
            this.dgvZahtjevi.Location = new System.Drawing.Point(12, 47);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.ReadOnly = true;
            this.dgvZahtjevi.RowHeadersWidth = 51;
            this.dgvZahtjevi.RowTemplate.Height = 29;
            this.dgvZahtjevi.Size = new System.Drawing.Size(918, 250);
            this.dgvZahtjevi.TabIndex = 1;
            this.dgvZahtjevi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZahtjevi_CellContentClick);
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "VrijemeKreiranja";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Vrsta
            // 
            this.Vrsta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vrsta.DataPropertyName = "VrstaZahtjeva";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.MinimumWidth = 6;
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.ReadOnly = true;
            // 
            // Svrha
            // 
            this.Svrha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.MinimumWidth = 6;
            this.Svrha.Name = "Svrha";
            this.Svrha.ReadOnly = true;
            // 
            // Uplatnica
            // 
            this.Uplatnica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Uplatnica.DataPropertyName = "Uplatnica";
            this.Uplatnica.HeaderText = "Uplatnica";
            this.Uplatnica.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Uplatnica.MinimumWidth = 6;
            this.Uplatnica.Name = "Uplatnica";
            this.Uplatnica.ReadOnly = true;
            // 
            // Printano
            // 
            this.Printano.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Printano.DataPropertyName = "Printano";
            this.Printano.HeaderText = "Printano";
            this.Printano.MinimumWidth = 6;
            this.Printano.Name = "Printano";
            this.Printano.ReadOnly = true;
            this.Printano.TrueValue = "";
            // 
            // Brisi
            // 
            this.Brisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brisi.HeaderText = "";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Briši";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // Printaj
            // 
            this.Printaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Printaj.HeaderText = "";
            this.Printaj.MinimumWidth = 6;
            this.Printaj.Name = "Printaj";
            this.Printaj.ReadOnly = true;
            this.Printaj.Text = "Printaj";
            this.Printaj.UseColumnTextForButtonValue = true;
            // 
            // grpThreading
            // 
            this.grpThreading.Controls.Add(this.txtInfo);
            this.grpThreading.Controls.Add(this.btnDodaj);
            this.grpThreading.Controls.Add(this.lblBroj);
            this.grpThreading.Controls.Add(this.txtBroj);
            this.grpThreading.Controls.Add(this.txtSvrha);
            this.grpThreading.Controls.Add(this.lblSvrha);
            this.grpThreading.Controls.Add(this.cmbVrsta);
            this.grpThreading.Controls.Add(this.lblVrsta);
            this.grpThreading.Location = new System.Drawing.Point(12, 303);
            this.grpThreading.Name = "grpThreading";
            this.grpThreading.Size = new System.Drawing.Size(919, 219);
            this.grpThreading.TabIndex = 2;
            this.grpThreading.TabStop = false;
            this.grpThreading.Text = "Dodavanje zahtjeva za izdavanje uvjerenja";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(6, 80);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(907, 133);
            this.txtInfo.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(785, 46);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(128, 29);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj =>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(667, 24);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(98, 20);
            this.lblBroj.TabIndex = 5;
            this.lblBroj.Text = "Broj zahtjeva:";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(667, 47);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(112, 27);
            this.txtBroj.TabIndex = 4;
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(295, 47);
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(366, 27);
            this.txtSvrha.TabIndex = 3;
            // 
            // lblSvrha
            // 
            this.lblSvrha.AutoSize = true;
            this.lblSvrha.Location = new System.Drawing.Point(295, 24);
            this.lblSvrha.Name = "lblSvrha";
            this.lblSvrha.Size = new System.Drawing.Size(115, 20);
            this.lblSvrha.TabIndex = 2;
            this.lblSvrha.Text = "Svrha izdavanja:";
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Items.AddRange(new object[] {
            "Uvjerenje o položenim ispitima",
            "Uvjerenje o statusu studenta"});
            this.cmbVrsta.Location = new System.Drawing.Point(6, 46);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(283, 28);
            this.cmbVrsta.TabIndex = 1;
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Location = new System.Drawing.Point(6, 23);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(108, 20);
            this.lblVrsta.TabIndex = 0;
            this.lblVrsta.Text = "Vrsta uvjerenja:";
            // 
            // frmUvjerenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 534);
            this.Controls.Add(this.grpThreading);
            this.Controls.Add(this.dgvZahtjevi);
            this.Controls.Add(this.btnNoviZahtjev);
            this.Name = "frmUvjerenja";
            this.Text = "frmUvjerenja";
            this.Load += new System.EventHandler(this.frmUvjerenja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.grpThreading.ResumeLayout(false);
            this.grpThreading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNoviZahtjev;
        private DataGridView dgvZahtjevi;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
        private GroupBox grpThreading;
        private ComboBox cmbVrsta;
        private Label lblVrsta;
        private TextBox txtSvrha;
        private Label lblSvrha;
        private TextBox txtInfo;
        private Button btnDodaj;
        private Label lblBroj;
        private TextBox txtBroj;
    }
}
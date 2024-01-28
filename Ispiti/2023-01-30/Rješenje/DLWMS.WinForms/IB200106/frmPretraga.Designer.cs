namespace DLWMS.WinForms.IB200106
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSpolovi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.brojIndeksa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnUvjerenja = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spol:";
            // 
            // cmbSpolovi
            // 
            this.cmbSpolovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpolovi.FormattingEnabled = true;
            this.cmbSpolovi.Location = new System.Drawing.Point(60, 12);
            this.cmbSpolovi.Name = "cmbSpolovi";
            this.cmbSpolovi.Size = new System.Drawing.Size(167, 28);
            this.cmbSpolovi.TabIndex = 1;
            this.cmbSpolovi.SelectedIndexChanged += new System.EventHandler(this.cmbSpolovi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "rođen u periodu od:";
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(380, 10);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(250, 27);
            this.dtpOd.TabIndex = 3;
            this.dtpOd.ValueChanged += new System.EventHandler(this.dtpOd_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "do:";
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(672, 10);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(250, 27);
            this.dtpDo.TabIndex = 5;
            this.dtpDo.ValueChanged += new System.EventHandler(this.dtpDo_ValueChanged);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojIndeksa,
            this.ImePrezime,
            this.Prosjek,
            this.DatumRodjenja,
            this.Aktivan,
            this.btnUvjerenja});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 46);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 29;
            this.dgvStudenti.Size = new System.Drawing.Size(910, 378);
            this.dgvStudenti.TabIndex = 6;
            this.dgvStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellContentClick);
            // 
            // brojIndeksa
            // 
            this.brojIndeksa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brojIndeksa.DataPropertyName = "BrojIndeksa";
            this.brojIndeksa.HeaderText = "Broj indeksa";
            this.brojIndeksa.MinimumWidth = 6;
            this.brojIndeksa.Name = "brojIndeksa";
            this.brojIndeksa.ReadOnly = true;
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
            // Prosjek
            // 
            this.Prosjek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.MinimumWidth = 6;
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rođenja";
            this.DatumRodjenja.MinimumWidth = 6;
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.MinimumWidth = 6;
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aktivan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnUvjerenja
            // 
            this.btnUvjerenja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnUvjerenja.HeaderText = "";
            this.btnUvjerenja.MinimumWidth = 6;
            this.btnUvjerenja.Name = "btnUvjerenja";
            this.btnUvjerenja.ReadOnly = true;
            this.btnUvjerenja.Text = "Uvjerenja";
            this.btnUvjerenja.UseColumnTextForButtonValue = true;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 436);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSpolovi);
            this.Controls.Add(this.label1);
            this.Name = "frmPretraga";
            this.Text = "Pretraga studenata";
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbSpolovi;
        private Label label2;
        private DateTimePicker dtpOd;
        private Label label3;
        private DateTimePicker dtpDo;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn brojIndeksa;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnUvjerenja;
    }
}
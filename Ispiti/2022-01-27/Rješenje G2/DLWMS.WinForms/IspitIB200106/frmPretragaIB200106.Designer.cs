
namespace DLWMS.WinForms.IspitIB200106
{
    partial class frmPretragaIB200106
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
            this.lblMinOcjena = new System.Windows.Forms.Label();
            this.cmbOcjene = new System.Windows.Forms.ComboBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvStudentiPredmeti = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Rb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seminarski = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpThread = new System.Windows.Forms.GroupBox();
            this.lblBrojOcjena = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtBrOcjena = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPredmeti)).BeginInit();
            this.grpThread.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMinOcjena
            // 
            this.lblMinOcjena.AutoSize = true;
            this.lblMinOcjena.Location = new System.Drawing.Point(9, 19);
            this.lblMinOcjena.Name = "lblMinOcjena";
            this.lblMinOcjena.Size = new System.Drawing.Size(121, 17);
            this.lblMinOcjena.TabIndex = 0;
            this.lblMinOcjena.Text = "Minimalna ocjena:";
            // 
            // cmbOcjene
            // 
            this.cmbOcjene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOcjene.FormattingEnabled = true;
            this.cmbOcjene.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOcjene.Location = new System.Drawing.Point(136, 16);
            this.cmbOcjene.Name = "cmbOcjene";
            this.cmbOcjene.Size = new System.Drawing.Size(121, 24);
            this.cmbOcjene.TabIndex = 1;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(263, 12);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(78, 30);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dgvStudentiPredmeti
            // 
            this.dgvStudentiPredmeti.AllowUserToAddRows = false;
            this.dgvStudentiPredmeti.AllowUserToDeleteRows = false;
            this.dgvStudentiPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rb,
            this.Student,
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Seminarski});
            this.dgvStudentiPredmeti.Location = new System.Drawing.Point(12, 46);
            this.dgvStudentiPredmeti.Name = "dgvStudentiPredmeti";
            this.dgvStudentiPredmeti.ReadOnly = true;
            this.dgvStudentiPredmeti.RowHeadersWidth = 51;
            this.dgvStudentiPredmeti.RowTemplate.Height = 24;
            this.dgvStudentiPredmeti.Size = new System.Drawing.Size(776, 226);
            this.dgvStudentiPredmeti.TabIndex = 3;
            this.dgvStudentiPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentiPredmeti_CellContentClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(708, 278);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 32);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Printaj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Rb
            // 
            this.Rb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rb.DataPropertyName = "Id";
            this.Rb.HeaderText = "Rb";
            this.Rb.MinimumWidth = 6;
            this.Rb.Name = "Rb";
            this.Rb.ReadOnly = true;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Ime i prezime";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
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
            this.Datum.DataPropertyName = "DatumPolaganja";
            this.Datum.HeaderText = "Datum polaganja";
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
            // Seminarski
            // 
            this.Seminarski.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seminarski.HeaderText = "";
            this.Seminarski.MinimumWidth = 6;
            this.Seminarski.Name = "Seminarski";
            this.Seminarski.ReadOnly = true;
            this.Seminarski.Text = "Seminraski";
            this.Seminarski.UseColumnTextForButtonValue = true;
            // 
            // grpThread
            // 
            this.grpThread.Controls.Add(this.cmbStudenti);
            this.grpThread.Controls.Add(this.btnDodaj);
            this.grpThread.Controls.Add(this.txtInfo);
            this.grpThread.Controls.Add(this.txtBrOcjena);
            this.grpThread.Controls.Add(this.lblInfo);
            this.grpThread.Controls.Add(this.lblStudent);
            this.grpThread.Controls.Add(this.lblBrojOcjena);
            this.grpThread.Location = new System.Drawing.Point(12, 278);
            this.grpThread.Name = "grpThread";
            this.grpThread.Size = new System.Drawing.Size(690, 160);
            this.grpThread.TabIndex = 5;
            this.grpThread.TabStop = false;
            this.grpThread.Text = "Dodavanje položenih:";
            // 
            // lblBrojOcjena
            // 
            this.lblBrojOcjena.AutoSize = true;
            this.lblBrojOcjena.Location = new System.Drawing.Point(6, 23);
            this.lblBrojOcjena.Name = "lblBrojOcjena";
            this.lblBrojOcjena.Size = new System.Drawing.Size(83, 17);
            this.lblBrojOcjena.TabIndex = 0;
            this.lblBrojOcjena.Text = "Broj ocjena:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(6, 68);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(61, 17);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Student:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(142, 23);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 17);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Info:";
            // 
            // txtBrOcjena
            // 
            this.txtBrOcjena.Location = new System.Drawing.Point(9, 43);
            this.txtBrOcjena.Name = "txtBrOcjena";
            this.txtBrOcjena.Size = new System.Drawing.Size(130, 22);
            this.txtBrOcjena.TabIndex = 4;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(145, 43);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(539, 111);
            this.txtInfo.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(64, 124);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 30);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj =>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.Location = new System.Drawing.Point(9, 89);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(130, 24);
            this.cmbStudenti.TabIndex = 7;
            // 
            // frmPretragaIB200106
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpThread);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvStudentiPredmeti);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.cmbOcjene);
            this.Controls.Add(this.lblMinOcjena);
            this.Name = "frmPretragaIB200106";
            this.Text = "Ukupno zapisa: 0";
            this.Load += new System.EventHandler(this.frmPretragaIB200106_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPredmeti)).EndInit();
            this.grpThread.ResumeLayout(false);
            this.grpThread.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinOcjena;
        private System.Windows.Forms.ComboBox cmbOcjene;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvStudentiPredmeti;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Seminarski;
        private System.Windows.Forms.GroupBox grpThread;
        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtBrOcjena;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblBrojOcjena;
    }
}
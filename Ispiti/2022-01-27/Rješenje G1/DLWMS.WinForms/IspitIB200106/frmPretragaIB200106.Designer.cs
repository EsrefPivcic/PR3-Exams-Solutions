
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPredmet = new System.Windows.Forms.TextBox();
            this.dgvStudentiPredmeti = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPolaganja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Slike = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpSuma = new System.Windows.Forms.GroupBox();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.txtOd = new System.Windows.Forms.TextBox();
            this.txtDo = new System.Windows.Forms.TextBox();
            this.btnSumiraj = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPredmeti)).BeginInit();
            this.grpSuma.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv predmeta:";
            // 
            // txtPredmet
            // 
            this.txtPredmet.Location = new System.Drawing.Point(126, 12);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.Size = new System.Drawing.Size(662, 22);
            this.txtPredmet.TabIndex = 1;
            this.txtPredmet.TextChanged += new System.EventHandler(this.txtPredmet_TextChanged);
            // 
            // dgvStudentiPredmeti
            // 
            this.dgvStudentiPredmeti.AllowUserToAddRows = false;
            this.dgvStudentiPredmeti.AllowUserToDeleteRows = false;
            this.dgvStudentiPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Predmet,
            this.DatumPolaganja,
            this.Ocjena,
            this.Brisi,
            this.Slike});
            this.dgvStudentiPredmeti.Location = new System.Drawing.Point(12, 40);
            this.dgvStudentiPredmeti.Name = "dgvStudentiPredmeti";
            this.dgvStudentiPredmeti.ReadOnly = true;
            this.dgvStudentiPredmeti.RowHeadersWidth = 51;
            this.dgvStudentiPredmeti.RowTemplate.Height = 24;
            this.dgvStudentiPredmeti.Size = new System.Drawing.Size(776, 261);
            this.dgvStudentiPredmeti.TabIndex = 2;
            this.dgvStudentiPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentiPredmeti_CellContentClick);
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
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // DatumPolaganja
            // 
            this.DatumPolaganja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumPolaganja.DataPropertyName = "DatumPolaganja";
            this.DatumPolaganja.HeaderText = "Datum polaganja";
            this.DatumPolaganja.MinimumWidth = 6;
            this.DatumPolaganja.Name = "DatumPolaganja";
            this.DatumPolaganja.ReadOnly = true;
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
            // Brisi
            // 
            this.Brisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brisi.HeaderText = "";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Briši predmet";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // Slike
            // 
            this.Slike.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Slike.HeaderText = "";
            this.Slike.MinimumWidth = 6;
            this.Slike.Name = "Slike";
            this.Slike.ReadOnly = true;
            this.Slike.Text = "Slike";
            this.Slike.UseColumnTextForButtonValue = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(711, 307);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(77, 34);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Printaj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpSuma
            // 
            this.grpSuma.Controls.Add(this.txtSuma);
            this.grpSuma.Controls.Add(this.lblSuma);
            this.grpSuma.Controls.Add(this.btnSumiraj);
            this.grpSuma.Controls.Add(this.txtDo);
            this.grpSuma.Controls.Add(this.txtOd);
            this.grpSuma.Controls.Add(this.lblDo);
            this.grpSuma.Controls.Add(this.lblOd);
            this.grpSuma.Location = new System.Drawing.Point(12, 307);
            this.grpSuma.Name = "grpSuma";
            this.grpSuma.Size = new System.Drawing.Size(693, 83);
            this.grpSuma.TabIndex = 4;
            this.grpSuma.TabStop = false;
            this.grpSuma.Text = "Sumiraj brojeve";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(6, 24);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(31, 17);
            this.lblOd.TabIndex = 0;
            this.lblOd.Text = "Od:";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(135, 24);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(30, 17);
            this.lblDo.TabIndex = 1;
            this.lblDo.Text = "Do:";
            // 
            // txtOd
            // 
            this.txtOd.Location = new System.Drawing.Point(9, 44);
            this.txtOd.Name = "txtOd";
            this.txtOd.Size = new System.Drawing.Size(123, 22);
            this.txtOd.TabIndex = 2;
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(138, 44);
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(123, 22);
            this.txtDo.TabIndex = 3;
            // 
            // btnSumiraj
            // 
            this.btnSumiraj.Location = new System.Drawing.Point(267, 40);
            this.btnSumiraj.Name = "btnSumiraj";
            this.btnSumiraj.Size = new System.Drawing.Size(94, 30);
            this.btnSumiraj.TabIndex = 4;
            this.btnSumiraj.Text = "Sumiraj =>";
            this.btnSumiraj.UseVisualStyleBackColor = true;
            this.btnSumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(364, 24);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(48, 17);
            this.lblSuma.TabIndex = 5;
            this.lblSuma.Text = "Suma:";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(367, 44);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.ReadOnly = true;
            this.txtSuma.Size = new System.Drawing.Size(320, 22);
            this.txtSuma.TabIndex = 6;
            // 
            // frmPretragaIB200106
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.grpSuma);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvStudentiPredmeti);
            this.Controls.Add(this.txtPredmet);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPretragaIB200106";
            this.Text = "Ukupno prikaza: 0";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPredmeti)).EndInit();
            this.grpSuma.ResumeLayout(false);
            this.grpSuma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPredmet;
        private System.Windows.Forms.DataGridView dgvStudentiPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaganja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
        private System.Windows.Forms.DataGridViewButtonColumn Slike;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grpSuma;
        private System.Windows.Forms.TextBox txtDo;
        private System.Windows.Forms.TextBox txtOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Button btnSumiraj;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label lblSuma;
    }
}
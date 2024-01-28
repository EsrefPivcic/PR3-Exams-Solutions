namespace DLWMS.WinForms.IB200106
{
    partial class frmNovoUvjerenje
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.picUplatnica = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUplatnica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta uvjerenja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Svrha izdavanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Skenirana uplatnica:";
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(12, 86);
            this.txtSvrha.Multiline = true;
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(245, 231);
            this.txtSvrha.TabIndex = 3;
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Items.AddRange(new object[] {
            "Uvjerenje o položenim ispitima",
            "Uvjerenje o statusu studenta"});
            this.cmbVrsta.Location = new System.Drawing.Point(12, 32);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(245, 28);
            this.cmbVrsta.TabIndex = 4;
            // 
            // picUplatnica
            // 
            this.picUplatnica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUplatnica.Location = new System.Drawing.Point(272, 32);
            this.picUplatnica.Name = "picUplatnica";
            this.picUplatnica.Size = new System.Drawing.Size(564, 250);
            this.picUplatnica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUplatnica.TabIndex = 5;
            this.picUplatnica.TabStop = false;
            this.picUplatnica.DoubleClick += new System.EventHandler(this.picUplatnica_DoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(742, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmNovoUvjerenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 329);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picUplatnica);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.txtSvrha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNovoUvjerenje";
            this.Text = "frmNovoUvjerenje";
            ((System.ComponentModel.ISupportInitialize)(this.picUplatnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSvrha;
        private ComboBox cmbVrsta;
        private PictureBox picUplatnica;
        private Button btnSave;
    }
}
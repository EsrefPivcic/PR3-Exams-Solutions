
namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    partial class frmGlavna
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
            this.btnGodine = new System.Windows.Forms.Button();
            this.btnPolozeni = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGodine
            // 
            this.btnGodine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGodine.Location = new System.Drawing.Point(12, 12);
            this.btnGodine.Name = "btnGodine";
            this.btnGodine.Size = new System.Drawing.Size(158, 146);
            this.btnGodine.TabIndex = 0;
            this.btnGodine.Text = "Godine studija";
            this.btnGodine.UseVisualStyleBackColor = true;
            this.btnGodine.Click += new System.EventHandler(this.btnGodine_Click);
            // 
            // btnPolozeni
            // 
            this.btnPolozeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolozeni.Location = new System.Drawing.Point(197, 12);
            this.btnPolozeni.Name = "btnPolozeni";
            this.btnPolozeni.Size = new System.Drawing.Size(158, 146);
            this.btnPolozeni.TabIndex = 1;
            this.btnPolozeni.Text = "Položeni predmeti";
            this.btnPolozeni.UseVisualStyleBackColor = true;
            this.btnPolozeni.Click += new System.EventHandler(this.btnPolozeni_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(379, 40);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(210, 91);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "Izračunaj sumu";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(379, 12);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(210, 22);
            this.txtSuma.TabIndex = 3;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(376, 143);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(48, 17);
            this.lblSuma.TabIndex = 4;
            this.lblSuma.Text = "Suma:";
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 170);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnPolozeni);
            this.Controls.Add(this.btnGodine);
            this.Name = "frmGlavna";
            this.Text = "Glavna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGodine;
        private System.Windows.Forms.Button btnPolozeni;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label lblSuma;
    }
}
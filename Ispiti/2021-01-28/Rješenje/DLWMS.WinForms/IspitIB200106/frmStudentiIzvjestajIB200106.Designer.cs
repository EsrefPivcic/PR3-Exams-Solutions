
namespace DLWMS.WinForms.IspitIB200106
{
    partial class frmStudentiIzvjestajIB200106
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.StudentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsStudentiIB200106 = new DLWMS.WinForms.IspitIB200106.dsStudentiIB200106();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.StudentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudentiIB200106)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentiBindingSource
            // 
            this.StudentiBindingSource.DataMember = "Studenti";
            this.StudentiBindingSource.DataSource = this.dsStudentiIB200106;
            // 
            // dsStudentiIB200106
            // 
            this.dsStudentiIB200106.DataSetName = "dsStudentiIB200106";
            this.dsStudentiIB200106.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StudentiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DLWMS.WinForms.IspitIB200106.rptStudentiIB200106.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1173, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // frmStudentiIzvjestajIB200106
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmStudentiIzvjestajIB200106";
            this.Text = "frmStudentiIzvjestajIB200106";
            this.Load += new System.EventHandler(this.frmStudentiIzvjestajIB200106_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudentiIB200106)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StudentiBindingSource;
        private dsStudentiIB200106 dsStudentiIB200106;
    }
}
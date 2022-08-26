using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.Entiteti;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.IspitIB200106
{
    public partial class frmIzvjestajIspitaIB200106 : Form
    {
        List<KorisnikIspitScanIB200106> _ispiti;
        public frmIzvjestajIspitaIB200106(List<KorisnikIspitScanIB200106> ispiti)
        {
            InitializeComponent();
            _ispiti = ispiti;
        }

        private void frmIzvjestajIspitaIB200106_Load(object sender, EventArgs e)
        {
            if (_ispiti != null && _ispiti.Count != 0)
            {
                var rds = new ReportDataSource();
                var tblIspiti = new dsIspitiIB200106.IspitiDataTable();
                var rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("student", _ispiti[0].Student.ToString()));
                foreach (var i in _ispiti)
                {
                    var red = tblIspiti.NewIspitiRow();
                    red.Predmet = i.Predmet.ToString();
                    red.Napomena = i.Napomena;
                    red.Varanje = i.Varanje ? "Da" : "Ne";
                    tblIspiti.Rows.Add(red);
                }
                rds.Name = "DataSet1";
                rds.Value = tblIspiti;
                reportViewer1.LocalReport.SetParameters(rpc);
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}

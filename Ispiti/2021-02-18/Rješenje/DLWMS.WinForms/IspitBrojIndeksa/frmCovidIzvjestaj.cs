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
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IspitBrojIndeksa;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.IspitBrojIndeksa
{
    public partial class frmCovidIzvjestaj : Form
    {
        List<StudentCovidTest> _testovi;
        public frmCovidIzvjestaj(List<StudentCovidTest> testovi)
        {
            InitializeComponent();
            _testovi = testovi;
        }

        private void frmCovidIzvjestaj_Load(object sender, EventArgs e)
        {
            if (_testovi != null)
            {
                var rds = new ReportDataSource();
                var tblTestovi = new dsTestovi.TestoviDataTable();
                foreach (var t in _testovi)
                {
                    var red = tblTestovi.NewTestoviRow();
                    red.Student = t.Student.ToString();
                    red.Datum = t.Datum.ToString();
                    red.Rezultat = t.Rezultat;
                    red.NalazDostavljen = t.NalazDostavljen ? "Da" : "Ne";
                    tblTestovi.Rows.Add(red);
                }
                rds.Name = "DataSet1";
                rds.Value = tblTestovi;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}

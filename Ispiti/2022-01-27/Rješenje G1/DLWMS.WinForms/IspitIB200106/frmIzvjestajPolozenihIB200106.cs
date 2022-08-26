using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.DB;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.IspitIB200106
{
    public partial class frmIzvjestajPolozenihIB200106 : Form
    {
        List<StudentPredmet> _studentiPredmeti;
        public frmIzvjestajPolozenihIB200106(List<StudentPredmet> studentiPredmeti)
        {
            InitializeComponent();
            _studentiPredmeti = studentiPredmeti;
        }

        private void frmIzvjestajPolozenihIB200106_Load(object sender, EventArgs e)
        {
            if (_studentiPredmeti != null && _studentiPredmeti.Count() != 0)
            {
                var rds = new ReportDataSource();
                var rpc = new ReportParameterCollection();
                var tblPolozeni = new dsPolozeni.PolozeniPredmetiDataTable();
                rpc.Add(new ReportParameter("prosjek", _studentiPredmeti.Average(x => x.Ocjena).ToString()));
                foreach (var sp in _studentiPredmeti)
                {
                    var red = tblPolozeni.NewPolozeniPredmetiRow();
                    red.ImePrezime = sp.Student.ToString();
                    red.Predmet = sp.Predmet.ToString();
                    red.Datum = sp.DatumPolaganja.ToString();
                    red.Ocjena = sp.Ocjena.ToString();
                    tblPolozeni.Rows.Add(red);
                }
                rds.Name = "DataSet1";
                rds.Value = tblPolozeni;
                reportViewer1.LocalReport.SetParameters(rpc);
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}

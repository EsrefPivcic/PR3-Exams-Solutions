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
    public partial class frmIzvjestajPolozenih : Form
    {
        List<StudentPredmet> _polozeni;
        public frmIzvjestajPolozenih(List<StudentPredmet> polozeni)
        {
            InitializeComponent();
            _polozeni = polozeni;
        }

        private void frmIzvjestajPolozenih_Load(object sender, EventArgs e)
        {
            if (_polozeni != null && _polozeni.Count() != 0)
            {
                var rds = new ReportDataSource();
                var rpc = new ReportParameterCollection();
                var tblPolozeni = new dsPolozeni.polozeniPredmetiDataTable();
                var rp1 = new ReportParameter("ukupno", _polozeni.Count().ToString());
                var rp2 = new ReportParameter("prosjek", _polozeni.Average(x => x.Ocjena).ToString());
                rpc.Add(rp1);
                rpc.Add(rp2);
                foreach (var p in _polozeni)
                {
                    var red = tblPolozeni.NewpolozeniPredmetiRow();
                    red.Rb = p.Id.ToString();
                    red.ImePrezime = p.Student.ToString();
                    red.Predmet = p.Student.ToString();
                    red.Datum = p.DatumPolaganja.ToString();
                    red.Ocjena = p.Ocjena.ToString();
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

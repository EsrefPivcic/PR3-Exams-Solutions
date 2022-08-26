using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpIntroWinForms.P10;
using Microsoft.Reporting.WinForms;

namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    public partial class frmPolozeniIzvjestaj : Form
    {
        List<KorisniciPredmeti> _polozeni;
        public frmPolozeniIzvjestaj(List<KorisniciPredmeti> polozeni)
        {
            InitializeComponent();
            _polozeni = polozeni;
        }

        private void frmPolozeniIzvjestaj_Load(object sender, EventArgs e)
        {
            if (_polozeni != null && _polozeni.Count() != 0)
            {
                var rds = new ReportDataSource();
                var tblPolozeni = new dsPolozeni.PolozeniPredmetiDataTable();
                var rpc = new ReportParameterCollection();
                var rp1 = new ReportParameter("korisnik", _polozeni[0].Korisnik.ToString());
                var rp2 = new ReportParameter("godina", _polozeni[0].Godina.ToString());
                rpc.Add(rp1);
                rpc.Add(rp2);
                foreach (var p in _polozeni)
                {
                    var red = tblPolozeni.NewPolozeniPredmetiRow();
                    red.Predmet = p.Predmet.ToString();
                    red.Ocjena = p.Ocjena.ToString();
                    red.Datum = p.Datum;
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

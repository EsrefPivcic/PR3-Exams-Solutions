using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpIntroWinForms.IspitBrojIndeksa;
using Microsoft.Reporting.WinForms;

namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    public partial class frmPorukeIzvjestaj : Form
    {
        List<KorisnikPoruka> _poruke;
        Korisnik _korisnik;
        public frmPorukeIzvjestaj(List<KorisnikPoruka> poruke, Korisnik korisnik)
        {
            InitializeComponent();
            _poruke = poruke;
            _korisnik = korisnik;
        }

        private void frmPorukeIzvjestaj_Load(object sender, EventArgs e)
        {
            if (_poruke != null && _poruke.Count() != 0)
            {
                var rds = new ReportDataSource();
                var rpc = new ReportParameterCollection();
                var tblPoruke = new dsPoruke.PorukeDataTable();
                rpc.Add(new ReportParameter("Korisnik", _korisnik.ToString()));
                for (int i = 0; i < _poruke.Count(); i++)
                {
                    var red = tblPoruke.NewPorukeRow();
                    red.Rb = $"{i + 1}";
                    red.Datum = _poruke[i].Datum.ToString();
                    red.Sadrzaj = _poruke[i].Sadrzaj;
                    tblPoruke.Rows.Add(red);
                }
                rds.Name = "DataSet1";
                rds.Value = tblPoruke;
                reportViewer1.LocalReport.SetParameters(rpc);
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}

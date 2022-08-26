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
    public partial class frmStudentiIzvjestajIB200106 : Form
    {
        List<Student> _studenti;
        public frmStudentiIzvjestajIB200106(List<Student> studenti)
        {
            InitializeComponent();
            _studenti = studenti;
        }

        private void frmStudentiIzvjestajIB200106_Load(object sender, EventArgs e)
        {
            if (_studenti != null && _studenti.Count() != 0)
            {
                var rds = new ReportDataSource();
                var tblStudenti = new dsStudentiIB200106.StudentiDataTable();
                for (int i = 0; i < _studenti.Count(); i++)
                {
                    var red = tblStudenti.NewStudentiRow();
                    red.RB = (i + 1).ToString();
                    red.Indeks = _studenti[i].Indeks;
                    red.Ime = _studenti[i].Ime;
                    red.Prezime = _studenti[i].Prezime;
                    red.Spol = _studenti[i].Spol.ToString();
                    red.Godina = _studenti[i].GodinaStudija.ToString();
                    red.Aktivan = _studenti[i].Aktivan ? "Da" : "Ne";
                    tblStudenti.Rows.Add(red);
                }
                rds.Name = "Data";
                rds.Value = tblStudenti;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}

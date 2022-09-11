using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;

namespace DLWMS.WinForms.IspitIB200106
{
    public partial class Pretraga : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<Student> _studenti;
        string _filter;
        ErrorProvider _error = new ErrorProvider();
        List<string> _samoglasnici = new List<string>{"a", "e", "i", "o", "u"};
        List<string> _znakovi = new List<string>{"?", "!", ".", ",", "<", ">", "*"};
        public Pretraga()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            _filter = txtPretraga.Text;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            _studenti = _db.Studenti.Where(s => s.Ime.ToLower().Contains(_filter.ToLower()) || s.Prezime.ToLower().Contains(_filter.ToLower())).ToList();
            if (_studenti != null && _studenti.Count() != 0)
            {
                DataTable tblStudenti = new DataTable();
                tblStudenti.Columns.Add("ImePrezime");
                tblStudenti.Columns.Add("Polozeni");
                tblStudenti.Columns.Add("BrojPolozenih");
                tblStudenti.Columns.Add("Prosjek");
                double prosjekSvih = 0;
                double najveci = 0;
                int brojac = 0;
                Student studentNajveci = new Student();
                for (int i = 0; i < _studenti.Count(); i++)
                {
                    var student = _studenti[i];
                    List<StudentiPredmeti> polozeni = _db.StudentiPredmeti.Where(x => x.Student.Id == student.Id).ToList();
                    double prosjekStudenta = 0;
                    string predmeti = "";
                    if (polozeni.Count() != 0)
                    {
                        prosjekStudenta = polozeni.Average(x => x.Ocjena);
                        prosjekSvih += prosjekStudenta;
                        brojac++;
                        for (int j = 0; j < polozeni.Count(); j++)
                        {
                            predmeti += $"{polozeni[j].Predmet};";
                        }
                    }                  
                    var red = tblStudenti.NewRow();
                    red["ImePrezime"] = student;
                    red["Polozeni"] = predmeti;
                    red["BrojPolozenih"] = polozeni.Count();
                    red["Prosjek"] = prosjekStudenta;
                    tblStudenti.Rows.Add(red);
                    if (najveci < prosjekStudenta)
                    {
                        najveci = prosjekStudenta;
                        studentNajveci = student;
                    }
                }
                prosjekSvih /= brojac;
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tblStudenti;
                lblProsjek.Text = $"Prosjek prikazanih ocjena: {prosjekSvih}";
                lblNajveci.Text = $"Najveći prosjek ostvario: {studentNajveci}";
            }
            else
            {
                lblProsjek.Text = $"Prosjek prikazanih ocjena: 0";
                lblNajveci.Text = $"Najveći prosjek ostvario: NOT SET";
                dgvStudenti.DataSource = null;
            }
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Student student = _studenti[e.RowIndex];
                frmScanIspitaIB200106 forma = new frmScanIspitaIB200106(student);
                forma.ShowDialog();
            }
        }

        private async void btnGenerisiInfo_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                await Task.Run(() => {
                    string text = txtSadrzaj.Text.ToLower();
                    long samoglasnici = text.Where(x => _samoglasnici.Contains(x.ToString())).Count();
                    long znakovi = text.Where(x => _znakovi.Contains(x.ToString())).Count();
                    long suglasnici = text.Length - samoglasnici - znakovi;
                    Action akcija = () => {
                        lblSamoglasnici.Text = $"Samoglasnika: {samoglasnici}";
                        lblSuglasnici.Text = $"Suglasnika: {suglasnici}";
                        lblZnakovi.Text = $"Znakova: {znakovi}";
                    };
                    BeginInvoke(akcija);
                });
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtSadrzaj, _error, Poruke.ObaveznaVrijednost);
        }
    }
}

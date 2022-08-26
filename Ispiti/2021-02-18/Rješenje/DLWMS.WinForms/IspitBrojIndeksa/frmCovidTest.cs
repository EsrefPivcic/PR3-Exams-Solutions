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
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.IspitBrojIndeksa;

namespace DLWMS.WinForms.IspitBrojIndeksa
{
    public partial class frmCovidTest : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<StudentCovidTest> _testovi;
        ErrorProvider _error = new ErrorProvider();
        public frmCovidTest()
        {
            InitializeComponent();
            dgvTestovi.AutoGenerateColumns = false;
        }

        private void frmCovidTest_Load(object sender, EventArgs e)
        {
            UcitajTestove();
            cmbStudenti.DataSource = _db.Studenti.ToList();
        }

        private void UcitajTestove()
        {
            _testovi = _db.StudentiCovidTestovi.ToList();
            if (_testovi != null && _testovi.Count() != 0)
            {
                btnBrisi.Enabled = true;
                btnPrint.Enabled = true;
                dgvTestovi.DataSource = null;
                dgvTestovi.DataSource = _testovi;
                lblBroj.Text = $"Broj testova: {_testovi.Count()}";
            }
            else
            {
                dgvTestovi.DataSource = null;
                lblBroj.Text = "Broj testova: 0";
                btnBrisi.Enabled = false;
                btnPrint.Enabled = false;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj() && !StudentDatumIsti())
            {
                StudentCovidTest novi = new StudentCovidTest
                {
                    Student = cmbStudenti.SelectedItem as Student,
                    Datum = dtpDatum.Value,
                    Rezultat = cmbRezultat.SelectedItem.ToString(),
                    NalazDostavljen = chkDostavljen.Checked
                };
                _db.StudentiCovidTestovi.Add(novi);
                _db.SaveChanges();
                UcitajTestove();
                MessageBox.Show("Uspješno ste evidentirali COVID test u bazi podataka!", "Obavijest.");
            }
            else if (Validiraj() && StudentDatumIsti())
            {
                MessageBox.Show("U bazu podataka nije moguće dodati više testova sa istim datumom za jednog studenta!", "Upozorenje!");
            }
        }

        private bool StudentDatumIsti()
        {
            if (_testovi != null && _testovi.Count() != 0)
            {
                for (int i = 0; i < _testovi.Count(); i++)
                {
                    if (_testovi[i].Student == cmbStudenti.SelectedItem as Student &&
                        _testovi[i].Datum.Date == dtpDatum.Value.Date)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(cmbStudenti, _error, Poruke.ObaveznaVrijednost) &&
                    Validator.ValidirajKontrolu(cmbRezultat, _error, Poruke.ObaveznaVrijednost) &&
                    Validator.ValidirajKontrolu(dtpDatum, _error, Poruke.ObaveznaVrijednost);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmCovidIzvjestaj forma = new frmCovidIzvjestaj(_testovi);
            forma.ShowDialog();
        }

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati sve testove?", "Upozorenje!", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                await Task.Run(() => {
                    for (int i = 0; i < _testovi.Count(); i++)
                    {
                        _db.StudentiCovidTestovi.Remove(_testovi[i]);
                    }
                    _db.SaveChanges();
                    Action akcija = () => UcitajTestove();
                    BeginInvoke(akcija);
                    MessageBox.Show("Svi testovi su uspješno obrisani!", "Obavijest.");
                });               
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (ValidirajGenerisanje())
            {
                await Task.Run(() => {
                    int brojTestova = int.Parse(txtBrojTestova.Text);
                    Random random = new Random();
                    for (int i = 0; i < brojTestova; i++)
                    {
                        StudentCovidTest novi = new StudentCovidTest
                        {
                            Student = _db.Studenti.ToList().ElementAt(random.Next(0,6)),
                            Datum = DateTime.Now,
                            Rezultat = random.Next(0,2) == 0 ? "Negativan" : "Pozitivan",
                            NalazDostavljen = random.Next(0, 2) == 0
                        };
                        _db.StudentiCovidTestovi.Add(novi);
                    }
                    _db.SaveChanges();
                    Action akcija = (() => {
                        txtBrojTestova.Clear();
                        UcitajTestove();
                    });
                    BeginInvoke(akcija);
                    MessageBox.Show($"Uspješno dodano {brojTestova} testova!", "Obavijest.");
                });
            }
        }

        private bool ValidirajGenerisanje()
        {
            return Validator.ValidirajKontrolu(txtBrojTestova, _error, Poruke.ObaveznaVrijednost);
        }
    }
}

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
using DLWMS.WinForms.DB;
using DLWMS.WinForms.P5;

namespace DLWMS.WinForms.IspitIB200106
{
    public partial class frmPretragaIB200106 : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<StudentPredmet> _studentiPredmeti;
        ErrorProvider _error = new ErrorProvider();
        public frmPretragaIB200106()
        {
            InitializeComponent();
            dgvStudentiPredmeti.AutoGenerateColumns = false;
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            if (!string.IsNullOrWhiteSpace(cmbOcjene.Text))
            {
                int ocjena = int.Parse(cmbOcjene.SelectedItem.ToString());
                _studentiPredmeti = _db.StudentiPredmeti.Where(x => x.Ocjena >= ocjena).ToList();
                if (_studentiPredmeti != null && _studentiPredmeti.Count() != 0)
                {
                    dgvStudentiPredmeti.DataSource = null;
                    dgvStudentiPredmeti.DataSource = _studentiPredmeti;
                    this.Text = $"Ukupno prikaza: {_studentiPredmeti.Count()}";
                }
                else
                {
                    dgvStudentiPredmeti.DataSource = null;
                    this.Text = "Ukupno prikaza: 0";
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmIzvjestajPolozenih forma = new frmIzvjestajPolozenih(_studentiPredmeti);
            forma.ShowDialog();
        }

        private void dgvStudentiPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int index = e.RowIndex;
                Student student = _studentiPredmeti[index].Student;
                Predmet predmet = _studentiPredmeti[index].Predmet;
                frmStudentSeminraskiIB200106 forma = new frmStudentSeminraskiIB200106(predmet, student);
                forma.ShowDialog();
            }
        }

        private void frmPretragaIB200106_Load(object sender, EventArgs e)
        {
            cmbStudenti.DataSource = _db.Studenti.ToList();
            cmbStudenti.SelectedItem = null;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var student = cmbStudenti.SelectedItem as Student;
                await Task.Run(() => {
                    int brojOcjena = int.Parse(txtBrOcjena.Text);
                    Random random = new Random();
                    for (int i = 0; i <= brojOcjena; i++)
                    {
                        Thread.Sleep(500);
                        StudentPredmet novi = new StudentPredmet 
                        {
                            Student = student,
                            Predmet = _db.Predmeti.ToList().ElementAt(random.Next(0,4)),
                            Ocjena = random.Next(6,11),
                            DatumPolaganja = DateTime.Now
                        };
                        _db.StudentiPredmeti.Add(novi);
                        Action akcija = () => 
                        {
                            txtInfo.Text += $"Za {novi.Student} dodat polozeni -> {novi.Predmet} ({novi.Ocjena}) {Environment.NewLine}"; 
                        };
                        BeginInvoke(akcija);
                    }
                    Action akcija2 = () => 
                    {
                        txtBrOcjena.Clear();
                        cmbStudenti.SelectedItem = null;
                        UcitajPodatke();
                    };
                    _db.SaveChanges();
                    BeginInvoke(akcija2);
                    MessageBox.Show("Uspješno ste dodali položene predmete!", "Obavijest.");
                });              
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtBrOcjena, _error, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbStudenti, _error, Poruke.ObaveznaVrijednost);
        }
    }
}

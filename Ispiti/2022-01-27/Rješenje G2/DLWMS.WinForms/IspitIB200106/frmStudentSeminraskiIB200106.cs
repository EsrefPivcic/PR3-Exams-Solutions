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
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.P5;

namespace DLWMS.WinForms.IspitIB200106
{
    public partial class frmStudentSeminraskiIB200106 : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<PredmetSeminraski> _seminarski;
        Predmet _predmet;
        Student _student;
        int _brojac = 0;
        ErrorProvider _error = new ErrorProvider();
        OpenFileDialog _file = new OpenFileDialog();
        public frmStudentSeminraskiIB200106(Predmet predmet, Student student)
        {
            InitializeComponent();
            _predmet = predmet;
            _student = student;
        }

        private void frmStudentSeminraskiIB200106_Load(object sender, EventArgs e)
        {
            lblStudent.Text = $"{_student}";
            lblPredmet.Text = $"{_predmet}";
            UcitajSeminarski();
        }

        private void UcitajSeminarski()
        {
            _seminarski = _db.PredmetiSeminarski.Where(x => x.Student.Id == _student.Id && x.Predmet.Id == _predmet.Id).ToList();
            if (_seminarski != null && _seminarski.Count() != 0)
            {
                PrikaziSliku();
            }
        }

        private void PrikaziSliku()
        {
            PredmetSeminraski slika = _seminarski[_brojac];
            lblBrojac.Text = $"Stranica {_brojac + 1} / {_seminarski.Count()}";
            picSlika.Image = ImageHelper.FromByteToImage(slika.Slika);
            lblDatum.Text = $"{slika.Datum}";
            lblOpis.Text = $"{slika.Opis}";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                PredmetSeminraski novi = new PredmetSeminraski {
                    Student = _student,
                    Predmet = _predmet,
                    Slika = ImageHelper.FromImageToByte(picNovaSlika.Image),
                    Opis = txtOpis.Text,
                    Datum = DateTime.Now
                };
                _db.PredmetiSeminarski.Add(novi);
                _db.SaveChanges();
                txtOpis.Clear();
                picNovaSlika.Image = null;
                UcitajSeminarski();
                MessageBox.Show("Uspješno dodavanje nove slike!", "Obavijest.");
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(picNovaSlika, _error, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtOpis, _error, Poruke.ObaveznaVrijednost);
        }

        private void picNovaSlika_Click(object sender, EventArgs e)
        {
            if (_file.ShowDialog() == DialogResult.OK)
            {
                picNovaSlika.Image = Image.FromFile(_file.FileName);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int temp = _brojac + 1;
            if (temp < _seminarski.Count())
            {
                _brojac++;
                PrikaziSliku();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int temp = _brojac - 1;
            if (temp >= 0)
            {
                _brojac--;
                PrikaziSliku();
            }
        }
    }
}

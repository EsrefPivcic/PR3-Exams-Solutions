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
    public partial class frmStudentSlikeIB200106 : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        Student _student;
        List<StudentSlika> _slike;
        int _brojac = 0;
        ErrorProvider _error = new ErrorProvider();
        OpenFileDialog _file = new OpenFileDialog();
        public frmStudentSlikeIB200106(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void frmStudentSlikeIB200106_Load(object sender, EventArgs e)
        {
            UcitajSlike();
        }

        private void UcitajSlike()
        {
            _slike = _db.StudentiSlike.Where(x => x.Student.Id == _student.Id).ToList();
            if (_slike != null && _slike.Count() != 0)
            {
                PrikaziSliku();
            }
        }

        private void PrikaziSliku()
        {
            StudentSlika slika = _slike[_brojac];
            picSlika.Image = ImageHelper.FromByteToImage(slika.Slika);
            lblBrojac.Text = $"Slika {_brojac + 1} / {_slike.Count()}";
            lblDatum.Text = $"{slika.Datum}";
            lblOpis.Text = $"{slika.Opis}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int temp = _brojac + 1;
            if (temp < _slike.Count())
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                StudentSlika nova = new StudentSlika
                {
                    Student = _student,
                    Slika = ImageHelper.FromImageToByte(picNovaSlika.Image),
                    Opis = txtOpis.Text,
                    Datum = DateTime.Now
                };
                _db.StudentiSlike.Add(nova);
                _db.SaveChanges();
                txtOpis.Clear();
                picNovaSlika.Image = null;
                MessageBox.Show("Uspješno dodavanje slike!", "Obavijest.");
                UcitajSlike();
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(picNovaSlika, _error, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtOpis, _error, Poruke.ObaveznaVrijednost);
        }

        private void picNovaSlika_DoubleClick(object sender, EventArgs e)
        {
            if (_file.ShowDialog() == DialogResult.OK)
            {
                picNovaSlika.Image = Image.FromFile(_file.FileName);
            }
        }
    }
}

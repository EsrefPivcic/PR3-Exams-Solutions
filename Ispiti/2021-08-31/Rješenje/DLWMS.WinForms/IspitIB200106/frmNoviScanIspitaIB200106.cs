using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Entiteti;

namespace DLWMS.WinForms.IspitIB200106
{
    public partial class frmNoviScanIspitaIB200106 : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        KorisnikIspitScanIB200106 _ispit;
        Student _student;
        ErrorProvider _error = new ErrorProvider();
        OpenFileDialog _file = new OpenFileDialog();
        public frmNoviScanIspitaIB200106(KorisnikIspitScanIB200106 ispit)
        {
            InitializeComponent();
            _ispit = ispit;
        }

        public frmNoviScanIspitaIB200106(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void frmNoviScanIspitaIB200106_Load(object sender, EventArgs e)
        {
            if (_ispit != null)
            {
                cmbPredmeti.Text = _ispit.Predmet.ToString();
                txtNapomena.Text = _ispit.Napomena;
                picSlika.Image = ImageHelper.FromByteToImage(_ispit.Slika);
                chkVaranje.Checked = _ispit.Varanje;
                cmbPredmeti.Enabled = false;
                txtNapomena.ReadOnly = true;
                picSlika.Enabled = false;
                chkVaranje.Enabled = false;
                btnSpremi.Enabled = false;
            }
            else   
            {
                UcitajPredmete();
            }
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = _db.Predmet.ToList();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                KorisnikIspitScanIB200106 novi = new KorisnikIspitScanIB200106
                {
                    Student = _student,
                    Predmet = cmbPredmeti.SelectedItem as Predmet,
                    Napomena = txtNapomena.Text,
                    Varanje = chkVaranje.Checked,
                    Slika = ImageHelper.FromImageToByte(picSlika.Image)
                };
                _db.KorisniciIspitiScan.Add(novi);
                _db.SaveChanges();
                IspitDodan();
                Close();
            }
        }

        public bool IspitDodan()
        {
            return true;
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(cmbPredmeti, _error, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtNapomena, _error, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(picSlika, _error, Poruke.ObaveznaVrijednost);
        }

        private void picSlika_DoubleClick(object sender, EventArgs e)
        {
            if (_file.ShowDialog() == DialogResult.OK)
            {
                picSlika.Image = Image.FromFile(_file.FileName);
            }
        }
    }
}

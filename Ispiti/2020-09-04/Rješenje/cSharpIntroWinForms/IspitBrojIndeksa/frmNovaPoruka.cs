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
using cSharpIntroWinForms.P9;

namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    public partial class frmNovaPoruka : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
        Korisnik _korisnik;
        KorisnikPoruka _poruka;
        ErrorProvider _error = new ErrorProvider();
        OpenFileDialog _file = new OpenFileDialog();
        public frmNovaPoruka(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
            txtPrimalac.Text = $"{_korisnik}";
        }
        public frmNovaPoruka(KorisnikPoruka poruka)
        {
            InitializeComponent();
            _poruka = poruka;
            this.Text = "Poruka";
            UcitajPoruku();
        }

        private void UcitajPoruku()
        {
            if (_poruka != null)
            {
                txtPrimalac.Text = $"{_poruka.Korisnik}";
                txtSadrzaj.Text = $"{_poruka.Sadrzaj}";
                if (_poruka.Slika != null)
                {
                    picSlika.Image = ImageHelper.FromByteToImage(_poruka.Slika);
                }
                btnSpremi.Enabled = false;
                txtSadrzaj.ReadOnly = true;
                picSlika.Enabled = false;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                KorisnikPoruka nova = new KorisnikPoruka 
                { 
                    Korisnik = _korisnik,
                    Sadrzaj = txtSadrzaj.Text,
                    Slika = picSlika.Image != null ? ImageHelper.FromImageToByte(picSlika.Image) : null,
                    Datum = DateTime.Now
                };
                _db.KorisniciPoruke.Add(nova);
                _db.SaveChanges();
                PorukaSpremljena();
                this.Close();
            }
        }

        public bool PorukaSpremljena()
        {
            return true;
        }

        private bool Validiraj()
        {
            return Validator.ObaveznoPolje(txtSadrzaj, _error, "Obavezan unos!");
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

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
    public partial class frmKorisnikSlikePregled : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
        Korisnik _korisnik;
        List<KorisnikSlika> _slike;
        int _brojac = 0;
        OpenFileDialog _file = new OpenFileDialog();
        public frmKorisnikSlikePregled(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void frmKorisnikSlikePregled_Load(object sender, EventArgs e)
        {
            UcitajSlike();
        }

        private void UcitajSlike()
        {
            _slike = _db.KorisniciSlike.Where(x => x.Korisnik.Id == _korisnik.Id).ToList();
            if (_slike != null && _slike.Count() != 0)
            {               
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                PrikaziSliku();
            }
            else
            {
                MessageBox.Show($"Ovaj korisnik nema niti jednu sliku!{Environment.NewLine}Dvoklikom na picturebox dodajete novu sliku.", "Obavijest.");
                btnBack.Enabled = false;
                btnNext.Enabled = false;
            }
        }

        private void PrikaziSliku()
        {
            picSlika.Image = ImageHelper.FromByteToImage(_slike[_brojac].Slika);
        }

        private void picSlika_DoubleClick(object sender, EventArgs e)
        {
            if (_file.ShowDialog() == DialogResult.OK)
            {
                KorisnikSlika novaSlika = new KorisnikSlika
                {
                    Korisnik = _korisnik,
                    Slika = ImageHelper.FromImageToByte(Image.FromFile(_file.FileName))
                };
                _db.KorisniciSlike.Add(novaSlika);
                _db.SaveChanges();
                MessageBox.Show("Uspješno ste dodali novu sliku!", "Obavijest.");
                UcitajSlike();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int temp = _brojac + 1;
            if (temp < _slike.Count())
            {
                _brojac++;
                PrikaziSliku();
            }
            else
            {
                MessageBox.Show("Korisnik nema više slika!", "Upozorenje!");
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
            else
            {
                MessageBox.Show("Korisnik nema više slika!", "Upozorenje!");
            }
        }
    }
}

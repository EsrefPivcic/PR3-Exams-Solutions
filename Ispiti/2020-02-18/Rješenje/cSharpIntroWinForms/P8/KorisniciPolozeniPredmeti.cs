using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
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

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        Korisnik _korisnik;
        KonekcijaNaBazu _db = DLWMS.DB;
        List<KorisniciPredmeti> _polozeni;
        ErrorProvider _error = new ErrorProvider();

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;     
            
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            _korisnik = _db.Korisnici.Find(1);
            cmbPredmeti.DataSource = _db.Predmeti.ToList();
            cmbGodineStudija.DataSource = _db.GodineStudija.Where(g => g.Aktivna).ToList();
            UcitajPolozene();
        }

        private void UcitajPolozene()
        {
            _polozeni = _db.KorisniciPredmeti.Where(x => x.Korisnik.Id == _korisnik.Id).ToList();
            if (_polozeni != null && _polozeni.Count() != 0)
            {
                dgvPolozeniPredmeti.DataSource = null;
                dgvPolozeniPredmeti.DataSource = _polozeni;
            }
            else
            {
                dgvPolozeniPredmeti.DataSource = null;
            }
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                if (!GodinaPredmetPostoji())
                {
                    KorisniciPredmeti novi = new KorisniciPredmeti
                    {
                        Korisnik = _korisnik,
                        Predmet = cmbPredmeti.SelectedItem as Predmeti,
                        Godina = cmbGodineStudija.SelectedItem as GodinaStudija,
                        Ocjena = int.Parse(txtOcjena.Text),
                        Datum = dtpDatumPolaganja.Value.ToString() 
                    };
                    _db.KorisniciPredmeti.Add(novi);
                    _db.SaveChanges();
                    UcitajPolozene();
                }
                else
                {
                    MessageBox.Show("Već postoji istoimeni predmet na istoj godini studija!", "Upozorenje!");
                }
            }
        }

        private bool Validiraj()
        {
            return Validator.ObaveznoPolje(cmbPredmeti, _error, "Obavezan unos!") &&
            Validator.ObaveznoPolje(cmbGodineStudija, _error, "Obavezan unos!") && 
            Validator.ObaveznoPolje(txtOcjena, _error, "Obavezan unos!") &&
            Validator.ObaveznoPolje(dtpDatumPolaganja, _error, "Obavezan unos!");
        }

        private bool GodinaPredmetPostoji()
        {
            for (int i = 0; i < _polozeni.Count(); i++)
            {
                if (_polozeni[i].Godina == cmbGodineStudija.SelectedItem && _polozeni[i].Predmet == cmbPredmeti.SelectedItem)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            List<KorisniciPredmeti> polozeniGodina = _polozeni.Where(x => x.Godina == cmbGodineStudija.SelectedItem).ToList();
            frmPolozeniIzvjestaj forma = new frmPolozeniIzvjestaj(polozeniGodina);
            forma.ShowDialog();
        }
    }
}

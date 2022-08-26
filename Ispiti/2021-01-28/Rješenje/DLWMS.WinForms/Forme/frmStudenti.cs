using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DLWMS.WinForms.IspitIB200106;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        ErrorProvider _error = new ErrorProvider();
        List<Student> _studenti;

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            cmbAktivnost.SelectedIndex = 0;
            cmbGodineStudija.SelectedIndex = 0;
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbGodineStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbAktivnost_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            if (Validiraj())
            {
                UcitajStudente();
                if (_studenti != null && _studenti.Count() != 0)
                {
                    dgvStudenti.DataSource = null;
                    dgvStudenti.DataSource = _studenti;
                    UcitajLabele();
                }
                else
                {
                    dgvStudenti.DataSource = null;
                    OcistiLabele();
                }
            }
            else
            {
                dgvStudenti.DataSource = null;
                OcistiLabele();
            }
        }

        private void OcistiLabele()
        {
            lblBrojStudenata.Text = "Broj studenata: 0";
            lblProsjek.Text = "Prosječna ocjena: 0";
        }

        private void UcitajLabele()
        {
            List<StudentiPredmeti> studentiPredmeti;
            double prosjek = 0;
            double brojac = 0;
            for (int i = 0; i < _studenti.Count(); i++)
            {
                var student = _studenti[i]; 
                studentiPredmeti = _db.StudentiPredmeti.Where(x => x.Student.Id == student.Id).ToList();
                if (studentiPredmeti.Count() != 0)
                {
                    prosjek += studentiPredmeti.Average(x => x.Ocjena);
                    brojac++; 
                }
            }
            prosjek = brojac == 0 ? 0 : prosjek / brojac;
            lblProsjek.Text = $"Prosječna ocjena: {prosjek}";
            lblBrojStudenata.Text = $"Broj studenata: {_studenti.Count()}";
        }

        private void UcitajStudente()
        {
            int godina = cmbGodineStudija.SelectedItem.ToString() == "Sve" ?
                    0 : int.Parse(cmbGodineStudija.SelectedItem.ToString());
            string filter = txtImePrezime.Text;
            if (cmbAktivnost.SelectedItem.ToString() != "Svi")
            {
                bool aktivnost = cmbAktivnost.SelectedItem.ToString() == "Aktivni";
                _studenti = _db.Studenti.Where(x => (x.Ime.ToLower().Contains(filter.ToLower()) || x.Prezime.ToLower().Contains(filter.ToLower())) 
                && (x.GodinaStudija == godina || godina == 0) 
                && (x.Aktivan == aktivnost)).ToList();
            }
            else
            {
                _studenti = _db.Studenti.Where(x => (x.Ime.ToLower().Contains(filter.ToLower()) || x.Prezime.ToLower().Contains(filter.ToLower()))
                && (x.GodinaStudija == godina || godina == 0)).ToList();
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtImePrezime, _error, Poruke.ObaveznaVrijednost);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmStudentiIzvjestajIB200106 forma = new frmStudentiIzvjestajIB200106(_studenti);
            forma.ShowDialog();
        }

        private void btnPotvrde_Click(object sender, EventArgs e)
        {
            frmPotvrdeIB200106 forma = new frmPotvrdeIB200106();
            forma.ShowDialog();
        }
    }
}

using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
using cSharpIntroWinForms.P9;
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
using cSharpIntroWinForms.IspitBrojIndeksa;

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {

        KonekcijaNaBazu _db = DLWMS.DB;
        List<Korisnik> _korisnici;
        List<KorisniciPredmeti> _polozeni;
        string _filter;
        string _spol;
        bool _admin;
        ErrorProvider _error = new ErrorProvider();

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
            btnPrintaj.Enabled = false;
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            UcitajKorisnike();
        }

        private void cmbSpolovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajKorisnike();
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            UcitajKorisnike();
        }

        private void UcitajKorisnike()
        {
            _filter = string.IsNullOrEmpty(txtImePrezime.Text) ? "" : txtImePrezime.Text;
            _spol = cmbSpolovi.SelectedItem == null ? "" : cmbSpolovi.SelectedItem.ToString();
            _admin = chkAdmin.Checked;
            _korisnici = _db.Korisnici.Where(k => 
                (k.Ime.ToLower().Contains(_filter.ToLower()) || k.Prezime.ToLower().Contains(_filter.ToLower()) || _filter == "") &&
                (k.Spol.Naziv == _spol || _spol == "") &&
                (k.Admin == _admin)).ToList();
            if (_korisnici != null && _korisnici.Count() != 0)
            {
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = _korisnici;
                btnPrintaj.Enabled = true;
            }
            else
            {
                dgvKorisnici.DataSource = null;
                btnPrintaj.Enabled = false;
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            _polozeni = new List<KorisniciPredmeti>();
            List<KorisniciPredmeti> temp = _db.KorisniciPredmeti.ToList();
            for (int i = 0; i < _korisnici.Count(); i++)
            {
                for (int j = 0; j < temp.Count(); j++)
                {
                    if (_korisnici[i] == temp[j].Korisnik)
                    {
                        _polozeni.Add(temp[j]);
                    }
                }
            }
            frmPolozeniIzvjestaj forma = new frmPolozeniIzvjestaj(_polozeni);
            forma.ShowDialog();
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int index = e.RowIndex;
                var korisnik = _korisnici[index];
                frmKorisnikSlikePregled forma = new frmKorisnikSlikePregled(korisnik);
                forma.ShowDialog();
            }
        }

        private async void btnSuma_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                await Task.Run(() => {
                    ulong n = ulong.Parse(txtSuma.Text);
                    ulong suma = 0;
                    for (ulong i = 0; i < n; i++)
                    {
                        suma += i;
                    }
                    Action akcija = () => {
                        txtSuma.Clear();
                        lblSuma.Text = $"Suma: {suma}";
                    };
                    BeginInvoke(akcija);
                });
            }
        }

        private bool Validiraj()
        {
            return Validator.ObaveznoPolje(txtSuma, _error, "Obavezan unos!");
        }
    }
}

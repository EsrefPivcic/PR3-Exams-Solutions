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
using cSharpIntroWinForms.P9;
using cSharpIntroWinForms.P10;

namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    public partial class frmPretraga : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
        List<KorisniciPredmeti> _korisniciPredmeti;
        string _filter;
        ErrorProvider _error = new ErrorProvider();
        public frmPretraga()
        {
            InitializeComponent();
            dgvKorisniciPredmeti.AutoGenerateColumns = false;
        }

        private void txtNazivPredmeta_TextChanged(object sender, EventArgs e)
        {
            _filter = txtNazivPredmeta.Text;
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            if (_filter != null && _filter != "" && _filter != " ")
            {
                _korisniciPredmeti = _db.KorisniciPredmeti.Where(x => x.Predmet.Naziv.Contains(_filter)).ToList();
                if (_korisniciPredmeti != null && _korisniciPredmeti.Count() != 0)
                {
                    dgvKorisniciPredmeti.DataSource = null;
                    dgvKorisniciPredmeti.DataSource = _korisniciPredmeti;
                    lblProsjek.Text = $"Prosjek prikazanih ocjena: {_korisniciPredmeti.Average(x => x.Ocjena)}";
                }
                else
                {
                    dgvKorisniciPredmeti.DataSource = null;
                    lblProsjek.Text = "Prosjek prikazanih ocjena: 0";   
                }
            }
            else
            {
                dgvKorisniciPredmeti.DataSource = null;
                lblProsjek.Text = "Prosjek prikazanih ocjena: 0";
            }
        }

        private void dgvKorisniciPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int index = e.RowIndex;
                Korisnik korinsik = _korisniciPredmeti[index].Korisnik;
                frmPoruke forma = new frmPoruke(korinsik);
                forma.ShowDialog();
            }
        }

        private async void btnSumiraj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                await Task.Run(() => {
                    ulong broj = ulong.Parse(txtBroj.Text);
                    ulong suma = 0;
                    for (ulong i = 1; i <= broj; i++)
                    {
                        suma += i;
                    }
                    Action ackcija = () => lblSuma.Text = $"Suma: {suma}";
                    BeginInvoke(ackcija);
                });
            }
        }

        private bool Validiraj()
        {
            return Validator.ObaveznoPolje(txtBroj, _error, "Obavezan unos!");
        }
    }
}

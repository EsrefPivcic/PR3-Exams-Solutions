using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpIntroWinForms.P9;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.IspitBrojIndeksa;

namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    public partial class frmPoruke : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
        List<KorisnikPoruka> _poruke;
        Korisnik _korisnik;
        public frmPoruke(Korisnik korisnik)
        {
            InitializeComponent();
            dgvPoruke.AutoGenerateColumns = false;
            _korisnik = korisnik;
        }

        private void frmPoruke_Load(object sender, EventArgs e)
        {
            lblKorisnik.Text = $"Komunikacija sa: {_korisnik}";
            UcitajPoruke();
        }

        private void UcitajPoruke()
        {
            if (_korisnik != null)
            {
                _poruke = _db.KorisniciPoruke.Where(x => x.Korisnik.Id == _korisnik.Id).ToList();
                if (_poruke != null && _poruke.Count() != 0)
                {
                    dgvPoruke.DataSource = null;
                    dgvPoruke.DataSource = _poruke;
                    btnPrint.Enabled = true;
                }
                else
                {
                    dgvPoruke.DataSource = null;
                    btnPrint.Enabled = false;
                }
            }
            else
            {
                dgvPoruke.DataSource = null;
                btnPrint.Enabled = false;
            }
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            frmNovaPoruka forma = new frmNovaPoruka(_korisnik);
            forma.ShowDialog();
            if (forma.PorukaSpremljena())
            {
                UcitajPoruke();
            }
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati poruku?", "Upozorenje!", MessageBoxButtons.YesNo) 
                    == DialogResult.Yes)
                {
                    int index = e.RowIndex;
                    var poruka = _poruke[index];
                    _db.KorisniciPoruke.Remove(poruka);
                    _db.SaveChanges();
                    UcitajPoruke();
                }
            }
        }

        private void dgvPoruke_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var poruka = _poruke[index];
            frmNovaPoruka forma = new frmNovaPoruka(poruka);
            forma.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPorukeIzvjestaj forma = new frmPorukeIzvjestaj(_poruke, _korisnik);
            forma.ShowDialog();
        }
    }
}

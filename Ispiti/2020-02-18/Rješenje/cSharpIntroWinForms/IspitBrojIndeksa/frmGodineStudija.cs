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

namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    public partial class frmGodineStudija : Form
    {
        KonekcijaNaBazu _db = DLWMS.DB;
        List<GodinaStudija> _godine;
        ErrorProvider _error = new ErrorProvider();
        GodinaStudija _godinaEdit;
        bool _editing = false;
        public frmGodineStudija()
        {
            InitializeComponent();
            dgvGodine.AutoGenerateColumns = false;
        }

        private void frmGodineStudija_Load(object sender, EventArgs e)
        {
            UcitajGodine();
        }

        private void UcitajGodine()
        {
            _godine = _db.GodineStudija.ToList();
            if (_godine != null && _godine.Count() != 0)
            {
                dgvGodine.DataSource = null;
                dgvGodine.DataSource = _godine;
            }
            else
            {
                dgvGodine.DataSource = null;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                GodinaStudija nova = new GodinaStudija 
                { 
                    Naziv = txtNaziv.Text,
                    Aktivna = chkAktivna.Checked
                };
                if (!GodinaPostoji(nova) && _editing == false)
                {
                    _db.GodineStudija.Add(nova);
                    _db.SaveChanges();
                    txtNaziv.Clear();
                    chkAktivna.Checked = false;
                    UcitajGodine();
                    MessageBox.Show("Uspješno ste dodali novu godinu studija!", "Obavijest.");
                }
                else if (!GodinaPostoji(nova) && _editing == true)
                {
                    _db.GodineStudija.Find(_godinaEdit.Id).Naziv = nova.Naziv;
                    _db.GodineStudija.Find(_godinaEdit.Id).Aktivna = nova.Aktivna;
                    _db.SaveChanges();
                    txtNaziv.Clear();
                    chkAktivna.Checked = false;
                    UcitajGodine();
                    _editing = false;
                    MessageBox.Show("Uspješan edit godine studija!", "Obavijest.");
                }
                else
                {
                    MessageBox.Show("Već postoji istoimena godina studija!", "Upozorenje!");
                }
            }
            else
            {
                _editing = false;
                chkAktivna.Checked = false;
            }
        }

        private bool GodinaPostoji(GodinaStudija nova)
        {
            for (int i = 0; i < _godine.Count(); i++)
            {
                if (_godine[i].Naziv == nova.Naziv && _editing == false)
                {
                    return true;
                }
                else if (_godine[i].Naziv == nova.Naziv && _editing == true && _godine[i].Id != _godinaEdit.Id)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Validiraj()
        {
            return Validator.ObaveznoPolje(txtNaziv, _error, "Obavezan unos!");
        }

        private void dgvGodine_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _godinaEdit = _godine[index];
            txtNaziv.Text = _godinaEdit.Naziv;
            chkAktivna.Checked = _godinaEdit.Aktivna;
            _editing = true;
        }
    }
}

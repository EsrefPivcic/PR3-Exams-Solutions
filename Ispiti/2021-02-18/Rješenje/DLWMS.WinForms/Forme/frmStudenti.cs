using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DLWMS.WinForms.IspitBrojIndeksa;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<Student> _studenti;
        List<StudentiPredmeti> _studentiPredmeti;
        ErrorProvider _error = new ErrorProvider();

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void cmbOperatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }
       
        private void cmbOcjene_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }
        private void UcitajStudente()
        {
            if (Validiraj())
            {
                GetStudentiPredmeti();
                GetStudenti();
                if (_studenti != null && _studenti.Count() != 0)
                {
                    dgvStudenti.DataSource = null;
                    dgvStudenti.DataSource = _studenti;
                    lblBrojStudenata.Text = $"Broj studenata: {_studenti.Count()}";
                    lblProsjek.Text = $"Prosječna ocjena: {_studentiPredmeti.Average(o => o.Ocjena)}";
                }
                else
                {
                    dgvStudenti.DataSource = null;
                    lblBrojStudenata.Text = $"Broj studenata: 0";
                    lblProsjek.Text = $"Prosječna ocjena: 0";
                }
            }
        }

        private void GetStudentiPredmeti()
        {
            _studentiPredmeti = _db.StudentiPredmeti.Where(x => x.Datum >= dtpOd.Value && x.Datum <= dtpDo.Value.Date).ToList();
            int ocjena = int.Parse(cmbOcjene.SelectedItem.ToString());
            string operator_ = cmbOperatori.SelectedItem.ToString();
            switch (operator_)
            {
                case "=":
                    _studentiPredmeti = _studentiPredmeti.Where(x => x.Ocjena == ocjena).ToList();
                    break;
                case ">":
                    _studentiPredmeti = _studentiPredmeti.Where(x => x.Ocjena > ocjena).ToList();
                    break;
                case ">=":
                    _studentiPredmeti = _studentiPredmeti.Where(x => x.Ocjena >= ocjena).ToList();
                    break;
                case "<":
                    _studentiPredmeti = _studentiPredmeti.Where(x => x.Ocjena < ocjena).ToList();
                    break;
                case "<=":
                    _studentiPredmeti = _studentiPredmeti.Where(x => x.Ocjena <= ocjena).ToList();
                    break;
            }
        }

        private void GetStudenti()
        {
            if (_studentiPredmeti != null && _studentiPredmeti.Count() != 0)
            {
                _studenti = new List<Student>();
                for (int i = 0; i < _studentiPredmeti.Count(); i++)
                {
                    if (!_studenti.Contains(_studentiPredmeti[i].Student))
                    {
                        _studenti.Add(_studentiPredmeti[i].Student);
                    }
                }
            }
            else
            {
                _studenti = null;
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(dtpOd, _error, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(dtpDo, _error, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbOcjene, _error, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbOperatori, _error, Poruke.ObaveznaVrijednost);
        }

        private void btnCOVID_Click(object sender, EventArgs e)
        {
            frmCovidTest forma = new frmCovidTest();
            forma.ShowDialog();
        }
    }
}

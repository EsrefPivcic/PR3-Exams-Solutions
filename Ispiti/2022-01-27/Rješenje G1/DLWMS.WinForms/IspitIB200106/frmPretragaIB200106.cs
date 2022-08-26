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
using DLWMS.WinForms.DB;
using DLWMS.WinForms.P5;

namespace DLWMS.WinForms.IspitIB200106
{
    public partial class frmPretragaIB200106 : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<StudentPredmet> _studentiPredmeti;
        string _filter;
        ErrorProvider _error = new ErrorProvider();
        public frmPretragaIB200106()
        {
            InitializeComponent();
            dgvStudentiPredmeti.AutoGenerateColumns = false;
        }

        private void txtPredmet_TextChanged(object sender, EventArgs e)
        {
            _filter = txtPredmet.Text;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            _studentiPredmeti = _db.StudentiPredmeti.Where(x => x.Predmet.Naziv.ToLower().Contains(_filter.ToLower())).ToList();
            if (_studentiPredmeti != null && _studentiPredmeti.Count() != 0)
            {
                dgvStudentiPredmeti.DataSource = null;
                dgvStudentiPredmeti.DataSource = _studentiPredmeti;
                this.Text = $"Ukupno prikaza: {_studentiPredmeti.Count()}";
            }
            else
            {
                dgvStudentiPredmeti.DataSource = null;
                this.Text = "Ukupno prikaza: 0";
            }
        }

        private void dgvStudentiPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Da li ste sigurni da želite obrisati položeni predmet?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    int index = e.RowIndex;
                    var studentPredmet = _studentiPredmeti[index];
                    _db.StudentiPredmeti.Remove(studentPredmet);
                    _db.SaveChanges();
                    UcitajPodatke();
                    MessageBox.Show("Uspješno ste obrisali položeni predmet!", "Obavijest.");
                }
            }
            if (e.ColumnIndex == 5)
            {
                int index = e.RowIndex;
                Student student = _studentiPredmeti[index].Student;
                frmStudentSlikeIB200106 forma = new frmStudentSlikeIB200106(student);
                forma.ShowDialog();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmIzvjestajPolozenihIB200106 forma = new frmIzvjestajPolozenihIB200106(_studentiPredmeti);
            forma.ShowDialog();
        }

        private async void btnSumiraj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                await Task.Run(() => {
                    ulong Od = ulong.Parse(txtOd.Text);
                    ulong Do = ulong.Parse(txtDo.Text);
                    ulong suma = 0;
                    for (ulong i = Od; i <= Do; i++)
                    {
                        suma += i;
                    }
                    Action akcija = () => {
                        txtOd.Clear();
                        txtDo.Clear();
                        txtSuma.Text = suma.ToString();
                    };
                    BeginInvoke(akcija);
                });
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtOd, _error, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtDo, _error, Poruke.ObaveznaVrijednost);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.Data;
using DLWMS.Data.IB200106;
using DLWMS.WinForms.Izvjestaji;
using Microsoft.EntityFrameworkCore;
using DLWMS.WinForms.Helpers;

namespace DLWMS.WinForms.IB200106
{
    public partial class frmUvjerenja : Form
    {
        DLWMSDbContext _db = KonekcijaNaBazuIB200106.db;
        List<StudentUvjerenje> _uvjerenja;
        Student _student;
        ErrorProvider _error = new ErrorProvider();

        public frmUvjerenja(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void frmUvjerenja_Load(object sender, EventArgs e)
        {
            dgvZahtjevi.AutoGenerateColumns = false;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            _uvjerenja = _db.StudentiUvjerenja.Where(su => su.Student.Id == _student.Id).ToList();
            dgvZahtjevi.DataSource = null;
            dgvZahtjevi.DataSource = _uvjerenja;
            this.Text = $"Broj uvjerenja -> {_uvjerenja.Count()}";
            if (_uvjerenja.Count > 0 )
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            frmNovoUvjerenje novoUvjerenje = new frmNovoUvjerenje(_student);
            novoUvjerenje.ShowDialog();
            if (novoUvjerenje.UvjerenjeDodano())
            {
                UcitajPodatke();
            }
        }

        private void dgvZahtjevi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                StudentUvjerenje uvjerenje = _uvjerenja[index];
                if (e.ColumnIndex == 6)
                {
                    if (uvjerenje.Printano == true)
                    {
                        MessageBox.Show("Ovo uvjerenje je već isprintano!", "Obavijest."); //nije zatraženo u postavci
                    }
                    else
                    {
                        frmIzvjestaji izvjestaj = new frmIzvjestaji(uvjerenje);
                        izvjestaj.Show();
                        uvjerenje.Printano = true;
                        _db.Entry(uvjerenje).State = EntityState.Modified;
                        _db.SaveChanges();
                        UcitajPodatke();
                    }
                }
                if (e.ColumnIndex == 5)
                {
                    DialogResult upozorenje = MessageBox.Show("Da li sigurno želite obrisati ovo uvjerenje?", "Upozorenje!", MessageBoxButtons.YesNo);
                    if (upozorenje == DialogResult.Yes)
                    {
                        _db.StudentiUvjerenja.Remove(uvjerenje);
                        _db.SaveChanges();
                        UcitajPodatke();
                    }
                }
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                txtInfo.Clear();
                string vrsta = cmbVrsta.SelectedItem.ToString();
                await Task.Run(() => { 
                    int brojUvjerenja = int.Parse(txtBroj.Text);
                    string svrha = txtSvrha.Text;
                    string info;
                    byte[] slika = _db.StudentiUvjerenja.First().Uplatnica;
                    for (int i = 0; i < brojUvjerenja; i++)
                    {
                        Thread.Sleep(300);
                        StudentUvjerenje novoUvjerenje = new StudentUvjerenje
                        {
                            Student = _student,
                            VrijemeKreiranja = DateTime.Now,
                            VrstaZahtjeva = vrsta,
                            Svrha = svrha,
                            Uplatnica = slika,
                            Printano = false
                        };
                        _db.StudentiUvjerenja.Add(novoUvjerenje);
                        info = $"{DateTime.Now.ToLongTimeString()} -> {vrsta} {_student} u svrhu {svrha}" + Environment.NewLine;
                        Action akcija = () => txtInfo.Text += info;
                        BeginInvoke(akcija);
                    }
                    _db.SaveChanges();
                });
                MessageBox.Show($"Uspješno ste dodali {txtBroj.Text} zahtjeva za uvjerenje!", "Obavijest.");
                txtBroj.Clear();
                txtSvrha.Clear();
                UcitajPodatke();
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(cmbVrsta, _error, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtSvrha, _error, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtBroj, _error, Kljucevi.ObaveznaVrijednost);
        }
    }
}
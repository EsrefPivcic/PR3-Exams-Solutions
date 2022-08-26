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
using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System.IO;

namespace DLWMS.WinForms.IspitIB200106
{
    public partial class frmPotvrdeIB200106 : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<StudentPotvrdaIB200106> _potvrde;
        ErrorProvider _error = new ErrorProvider();
        public frmPotvrdeIB200106()
        {
            InitializeComponent();
            dgvPotvrde.AutoGenerateColumns = false;
        }

        private void frmPotvrdeIB200106_Load(object sender, EventArgs e)
        {
            UcitajPotvrde();
        }

        private void UcitajPotvrde()
        {
            _potvrde = _db.StudentiPotvrde.ToList();
            if (_potvrde != null && _potvrde.Count() != 0)
            {
                btnBrisi.Enabled = true;
                dgvPotvrde.DataSource = null;
                dgvPotvrde.DataSource = _potvrde;
                lblTrenutno.Text = $"Trenutno potvrda: {_potvrde.Count()}";
            }
            else
            {
                btnBrisi.Enabled = false;
                dgvPotvrde.DataSource = null;
                lblTrenutno.Text = "Trenutno potvrda: 0";
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                await Task.Run(() => {
                    int brojPotvrda = int.Parse(txtBrojPotvrda.Text);
                    Random random = new Random();
                    for (int i = 0; i < brojPotvrda; i++)
                    {
                        StudentPotvrdaIB200106 nova = new StudentPotvrdaIB200106 { 
                            Student = _db.Studenti.ToList().ElementAt(random.Next(0,6)),
                            Datum = DateTime.Now,
                            Svrha = $"Generisana potvrda ({i + 1})",
                            Izdata = random.Next(0, 2) == 0
                        };
                        _db.StudentiPotvrde.Add(nova);
                    }
                    _db.SaveChanges();
                    Action akcija = () => { 
                        UcitajPotvrde();
                        txtBrojPotvrda.Clear();
                    };
                    BeginInvoke(akcija);
                    MessageBox.Show("Uspješno ste dodali potvrde.", "Obavijest.");
                });
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtBrojPotvrda, _error, Poruke.ObaveznaVrijednost);
        }

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite obrisati sve potvrde?", "Upozorenje!", MessageBoxButtons.YesNo) 
                == DialogResult.Yes)
            {
                await Task.Run(() => {
                    for (int i = 0; i < _potvrde.Count(); i++)
                    {
                        var potvrda = _potvrde[i];
                        _db.StudentiPotvrde.Remove(potvrda);
                    }
                    _db.SaveChanges();
                    Action akcija = () =>
                    {
                        UcitajPotvrde();
                    };
                    BeginInvoke(akcija);
                    MessageBox.Show("Uspješno ste obrisali sve potvrde.", "Obavijest.");
                });
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Save(@"Potvrde.csv");
        }

        private void Save(string file)
        {
            using (StreamWriter sw = File.AppendText(file))
            {
                foreach (var potvrda in DLWMSdb.Baza.StudentiPotvrde)
                {
                    sw.WriteLine(potvrda.Id + "," + potvrda.Student + "," + potvrda.Svrha + "," + potvrda.Datum + "," + potvrda.Izdata);
                }
                sw.Close();
            }
            MessageBox.Show($"Uspješno ste spremili potvrde! {Environment.NewLine}Lokacija: Rješenje/DLWMS.WinForms/bin/Debug", "Obavijest.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.Data;
using DLWMS.Data.IB200106;

namespace DLWMS.WinForms.IB200106
{
    public partial class frmPretraga : Form
    {
        DLWMSDbContext _db = KonekcijaNaBazuIB200106.db;
        List<Student> _studenti;

        public frmPretraga()
        {
            InitializeComponent();
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            cmbSpolovi.DataSource = _db.Spolovi.ToList();
        }

        private void cmbSpolovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
            dtpDo.MinDate = dtpOd.Value;
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            Spol spolFilter = cmbSpolovi.SelectedItem as Spol;
            DateTime Od = dtpOd.Value;
            DateTime Do = dtpDo.Value;
            _studenti = _db.Studenti.Where(s => s.Spol.Id == spolFilter.Id &&
            (s.DatumRodjenja >= dtpOd.Value && s.DatumRodjenja <= dtpDo.Value)).ToList();
            if (_studenti.Count > 0)
            {
                DataTable tblStudenti = new DataTable();
                tblStudenti.Columns.Add("BrojIndeksa");
                tblStudenti.Columns.Add("ImePrezime");
                tblStudenti.Columns.Add("Prosjek");
                tblStudenti.Columns.Add("DatumRodjenja");
                tblStudenti.Columns.Add("Aktivan");
                for (int i = 0; i < _studenti.Count(); i++)
                {
                    var student = _studenti[i];
                    List<StudentPredmet> polozeni = _db.StudentiPredmeti.Where(sp => sp.Student.Id == student.Id).ToList();
                    DataRow red = tblStudenti.NewRow();
                    red["BrojIndeksa"] = student.BrojIndeksa;
                    red["ImePrezime"] = student.Ime + " " + student.Prezime; //jer u klasi student toString funkcija vraća i indeks sa imenom i prezimenom
                    red["Prosjek"] = polozeni.Count() == 0 ? 5 : polozeni.Average(p => p.Ocjena);
                    red["DatumRodjenja"] = student.DatumRodjenja;
                    red["Aktivan"] = student.Aktivan;
                    tblStudenti.Rows.Add(red);
                }
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tblStudenti;
            }
            else
            {
                dgvStudenti.DataSource = null;
                MessageBox.Show($"U bazi podataka ne postoji evidencija o studentima {spolFilter} spola rođenih u periodu od {dtpOd.Value} - {dtpDo.Value} godine.");
            }
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                var student = _studenti[index];
                if (e.ColumnIndex != 5)
                {
                    frmStudentInfo studentInfo = new frmStudentInfo(student);
                    studentInfo.ShowDialog();
                }
                else
                {
                    frmUvjerenja uvjerenja = new frmUvjerenja(student);
                    uvjerenja.ShowDialog();
                }
            }
        }
    }
}

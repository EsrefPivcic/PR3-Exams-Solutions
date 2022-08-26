using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;

namespace DLWMS.WinForms.IspitIB200106
{
    public partial class frmScanIspitaIB200106 : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<KorisnikIspitScanIB200106> _ispiti;
        Student _student;
        public frmScanIspitaIB200106(Student student)
        {
            InitializeComponent();
            _student = student;
            dgvIspiti.AutoGenerateColumns = false;
        }

        private void frmScanIspitaIB200106_Load(object sender, EventArgs e)
        {
            lblStudent.Text += $" {_student}.";
            UcitajIspite();
        }

        private void UcitajIspite()
        {
            _ispiti = _db.KorisniciIspitiScan.Where(x => x.Student.Id == _student.Id).ToList();
            if (_ispiti != null && _ispiti.Count() != 0)
            {
                dgvIspiti.DataSource = null;
                dgvIspiti.DataSource = _ispiti;
            }
            else
            {
                dgvIspiti.DataSource = null;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmNoviScanIspitaIB200106 forma = new frmNoviScanIspitaIB200106(_student);
            forma.ShowDialog();
            if (forma.IspitDodan())
            {
                UcitajIspite();
            }
        }

        private void dgvIspiti_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            KorisnikIspitScanIB200106 ispit = _ispiti[e.RowIndex];
            frmNoviScanIspitaIB200106 forma = new frmNoviScanIspitaIB200106(ispit);
            forma.ShowDialog();
        }

        private void dgvIspiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    KorisnikIspitScanIB200106 ispit = _ispiti[e.RowIndex];
                    _db.KorisniciIspitiScan.Remove(ispit);
                    _db.SaveChanges();
                    UcitajIspite();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmIzvjestajIspitaIB200106 forma = new frmIzvjestajIspitaIB200106(_ispiti);
            forma.ShowDialog();
        }
    }
}

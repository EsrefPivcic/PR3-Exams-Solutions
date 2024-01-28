using DLWMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.Helpers;
using DLWMS.Data.IB200106;

namespace DLWMS.WinForms.IB200106
{
    public partial class frmStudentInfo : Form
    {
        Student _student;
        DLWMSDbContext _db = KonekcijaNaBazuIB200106.db;
        public frmStudentInfo(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            picSlika.Image = ImageHelper.FromByteToImage(_student.Slika);
            lblImePrezime.Text = _student.Ime + " " + _student.Prezime;
            List<StudentPredmet> polozeni = _db.StudentiPredmeti.Where(sp => sp.Student.Id == _student.Id).ToList();
            double prosjek = polozeni.Average(p => p.Ocjena);
            lblProsjek.Text = $"Prosjek: {prosjek}";
        }
    }
}

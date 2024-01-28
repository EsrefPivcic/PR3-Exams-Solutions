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
    public partial class frmNovoUvjerenje : Form
    {
        Student _student;
        DLWMSDbContext _db = KonekcijaNaBazuIB200106.db;
        ErrorProvider _error = new ErrorProvider();
        OpenFileDialog _file = new OpenFileDialog();

        public frmNovoUvjerenje(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                StudentUvjerenje novo = new StudentUvjerenje
                {
                    Student = _student,
                    VrijemeKreiranja = DateTime.Now,
                    VrstaZahtjeva = cmbVrsta.SelectedItem.ToString(),
                    Svrha = txtSvrha.Text,
                    Uplatnica = ImageHelper.FromImageToByte(picUplatnica.Image),
                    Printano = false
                };
                _db.StudentiUvjerenja.Add(novo);
                _db.SaveChanges();
                UvjerenjeDodano();
                Close();
            }
        }

        public bool UvjerenjeDodano()
        {
            return true;
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(cmbVrsta, _error, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtSvrha, _error, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(picUplatnica, _error, Kljucevi.ObaveznaVrijednost);
        }

        private void picUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if (_file.ShowDialog() == DialogResult.OK)
            {
                picUplatnica.Image = Image.FromFile(_file.FileName);
            }
        }
    }
}

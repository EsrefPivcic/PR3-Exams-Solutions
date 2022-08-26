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
using cSharpIntroWinForms.P8;

namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    public partial class frmGlavna : Form
    {
        ErrorProvider _error = new ErrorProvider();

        public frmGlavna()
        {
            InitializeComponent();
        }

        private void btnGodine_Click(object sender, EventArgs e)
        {
            frmGodineStudija forma = new frmGodineStudija();
            forma.ShowDialog();
        }

        private void btnPolozeni_Click(object sender, EventArgs e)
        {
            KorisniciPolozeniPredmeti forma = new KorisniciPolozeniPredmeti();
            forma.ShowDialog();
        }

        private async void btnSuma_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                await Task.Run(() => {
                    ulong n = ulong.Parse(txtSuma.Text);
                    ulong suma = 0;
                    for (ulong i = 0; i <= n; i++)
                    {
                        suma += i;
                    }
                    Action akcija = () => {
                        txtSuma.Clear();
                        lblSuma.Text = $"Suma: {suma}";
                    };
                    BeginInvoke(akcija);
                });
            }
        }

        private bool Validiraj()
        {
            return Validator.ObaveznoPolje(txtSuma, _error, "Obavezan unos!");
        }
    }
}

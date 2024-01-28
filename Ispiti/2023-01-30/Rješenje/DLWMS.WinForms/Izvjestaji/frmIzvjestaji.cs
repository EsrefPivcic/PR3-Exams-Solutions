using Microsoft.Reporting.WinForms;
using DLWMS.WinForms.IB200106;
using DLWMS.Data.IB200106;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        StudentUvjerenje _uvjerenje;
        public frmIzvjestaji(StudentUvjerenje uvjerenje)
        {
            InitializeComponent();
            _uvjerenje = uvjerenje;
        }
        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            if (_uvjerenje != null)
            {
                ReportParameterCollection rpc = new ReportParameterCollection();
                ReportParameter student = new ReportParameter("student", _uvjerenje.Student.ToString());
                ReportParameter svrha = new ReportParameter("svrha", _uvjerenje.Svrha);
                ReportParameter vrsta = new ReportParameter("vrsta", _uvjerenje.VrstaZahtjeva);
                ReportParameter datum = new ReportParameter("datum", DateTime.Now.ToString());
                rpc.Add(student);
                rpc.Add(svrha);
                rpc.Add(vrsta);
                rpc.Add(datum);
                reportViewer1.LocalReport.SetParameters(rpc);
                reportViewer1.RefreshReport();
            }
        }
    }
}

using System;
using System.Windows.Forms;
using DLWMS.WinForms.IspitIB200106;

namespace DLWMS.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form forma = new Pretraga();
            Application.Run(forma);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS.WinForms.Entiteti;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.WinForms.IspitIB200106
{
    [Table("KorisniciIspitiScan")]
    public class KorisnikIspitScanIB200106
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Predmet Predmet { get; set; }
        public string Napomena { get; set; }
        public byte[] Slika { get; set; }
        public bool Varanje { get; set; }
    }
}

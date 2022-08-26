using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpIntroWinForms;
using System.ComponentModel.DataAnnotations.Schema;

namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    [Table("KorisniciPoruke")]
    public class KorisnikPoruka
    {
        public int Id { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public DateTime Datum { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }
    }
}

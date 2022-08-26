using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace cSharpIntroWinForms.IspitBrojIndeksa
{
    [Table("KorisniciSlike")]
    public class KorisnikSlika
    {
        public int Id { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public byte[] Slika { get; set; }
    }
}

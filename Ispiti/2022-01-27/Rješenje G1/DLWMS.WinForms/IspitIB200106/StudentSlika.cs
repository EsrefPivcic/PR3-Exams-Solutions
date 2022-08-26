using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS.WinForms.DB;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.WinForms.IspitIB200106
{   
    [Table("StudentiSlike")]
    public class StudentSlika
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public byte[] Slika { get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; }
    }
}

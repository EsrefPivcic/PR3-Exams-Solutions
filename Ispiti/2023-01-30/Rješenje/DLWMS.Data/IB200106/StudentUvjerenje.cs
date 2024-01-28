using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DLWMS.Data.IB200106
{
    [Table("StudentiUvjerenja")]
    public class StudentUvjerenje
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public string VrstaZahtjeva { get; set; }
        public string Svrha { get; set; }
        public byte[] Uplatnica { get; set; }
        public bool Printano { get; set; }
    }
}

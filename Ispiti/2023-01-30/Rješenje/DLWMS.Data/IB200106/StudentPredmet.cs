using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data.IB200106
{
    [Table("StudentiPredmeti")]
    public class StudentPredmet
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Predmet Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
    }
}

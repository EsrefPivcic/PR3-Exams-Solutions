using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using DLWMS.WinForms.Entiteti;

namespace DLWMS.WinForms.IspitIB200106
{
    [Table("StudentiPotvrde")]
    public class StudentPotvrdaIB200106
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public DateTime Datum { get; set; }
        public string Svrha { get; set; }
        public bool Izdata { get; set; }
    }
}

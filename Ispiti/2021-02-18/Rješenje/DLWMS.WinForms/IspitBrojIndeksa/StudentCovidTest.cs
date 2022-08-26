using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using DLWMS.WinForms.Entiteti;

namespace DLWMS.WinForms.IspitBrojIndeksa
{
    [Table("StudentiCovidTestovi")]
    public class StudentCovidTest
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public DateTime Datum { get; set; }
        public string Rezultat { get; set; }
        public bool NalazDostavljen { get; set; }
    }
}

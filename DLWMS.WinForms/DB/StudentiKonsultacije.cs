using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.DB
{
    public class StudentiKonsultacije
    {
        public int Id { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        [ForeignKey("Predmet")]
        public int PredmetId { get; set; }
        public virtual Predmet Predmet { get; set; }
        public string Datum { get; set; }
        public string Napomena { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.DB
{
    public class StudentPredmet
    {
        public int Id { get; set; }
        [ForeignKey("Student")]
        public int Student_Id { get; set; }
        public virtual Student Student { get; set; }
        [ForeignKey("Predmet")]
        public int Predmet_Id { get; set; }
        public virtual Predmet Predmet { get; set; }
        public int Ocjena { get; set; }
        public string DatumPolaganja { get; set; }
    }
}

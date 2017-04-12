using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie.Entities
{
    public class Medicament
    {
        [Key]
        public int MedID { get; set; }
        public string Description { get; set; }
        //public string BarCode { get; set; } //BarCode Scanner inavilable
        public string Family { get; set; }
        public string Form { get; set; }
        public string ClassTherap { get; set; }
        public string Price { get; set; }
        public double Qte { get; set; }
        public Laboratory Labo { get; set; }
        public Provider Provider { get; set; }
        public virtual List<Order> Orders { get; set; }

        public override string ToString()
        {
            return this.Description;
        }
    }
}

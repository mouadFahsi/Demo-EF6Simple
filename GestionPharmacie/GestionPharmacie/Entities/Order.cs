using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie.Entities
{
    public class Order
    {
        [Key]
        public int NumCmd { get; set; }
        public string ExtraInfo { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime PaymentDeadline { get; set; }
        public double Amount { get; set; }
        public bool Urgent { get; set; }
        public string Etat { get; set; }
        public virtual List<Medicament> Meds { get; set; }

        public override string ToString()
        {
            return NumCmd.ToString();
        }
    }
}

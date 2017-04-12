using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie.Entities
{
    public class Laboratory
    {
        [Key]
        public int LabID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public byte[] Pic { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

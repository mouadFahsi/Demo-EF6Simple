using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie.Entities
{
    public class Provider
    {
        public int ProviderID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

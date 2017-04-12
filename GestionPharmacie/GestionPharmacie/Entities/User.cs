using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie.Entities
{
    public class User
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public byte[] ProfilePic { get; set; }


        public override string ToString()
        {
            return this.UserName;
        }
        
    }
}

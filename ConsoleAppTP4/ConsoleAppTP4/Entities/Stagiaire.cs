using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTP4
{
    public class Stagiaire
    {
        public int Id { set; get; }
        public string Nom { set; get; }
        public string Prenom { set; get; }
        public DateTime DateNaissance { set; get; }
        public virtual Groupe Groupe { set; get; }

        public override string ToString()
        {
            return this.Nom + "," + this.Prenom;
        }
    }
}

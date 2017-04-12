using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Groupe grp1 = new Groupe();

            Stagiaire stg = new Stagiaire()
                                {
                                    Nom = "hamid",
                                    DateNaissance = Convert.ToDateTime("01/01/1995"),
                                    Prenom = "Salhi",
                                    Id = 1,
                                    Groupe = grp1
                                };
        }
    }
}

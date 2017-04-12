using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPharmacie.Entities;

namespace GestionPharmacie.Management.LaboratoriesManagement
{
    public class LabosServices
    {
        public Model_GestionPharmacie Db { get; set; }

        public bool Add(Laboratory lab)
        {
            Db.Labos.Add(lab);
            return Db.SaveChanges() > 0;
        }

        public bool Update(Laboratory lab)
        {
            Laboratory Origine = Db.Labos.Find(lab.LabID);
            if (Origine != null)
            {
                Db.Entry(Origine).CurrentValues.SetValues(lab);
                return Db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Laboratory> LabsList()
        {
            var query = from lab in Db.Labos select lab;
            return query.ToList();
        }

        /// <summary>
        /// Finds and changes the Lab state to Unchanged then return that Lab..
        /// </summary>
        /// <param name="id"></param>
        /// /// <returns>Laboratory</returns>
        public Laboratory FindExisted(int id)
        {
            Laboratory lab = Db.Labos.Find(id);
            Db.Entry(lab).State = System.Data.Entity.EntityState.Modified;
            return lab;
        }
    }
}

using GestionPharmacie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie.Management.MedicamentsManagement
{
    public class MedsServices
    {
        public Model_GestionPharmacie Db { get; set; }

        public bool Add(Medicament med)
        {
            Db.Meds.Add(med);
            return Db.SaveChanges() > 0;
        }

        public bool Update(Medicament med)
        {
            Medicament Origine = Db.Meds.Find(med.MedID);
            if (Origine != null)
            {
                Db.Entry(Origine).CurrentValues.SetValues(med);
                return Db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Medicament> MedsList()
        {
            var query = from med in Db.Meds select med;
            return query.ToList();
        }

        /// <summary>
        /// Finds and changes the Med state to Unchanged then return that Med..
        /// </summary>
        /// <param name="id"></param>
        /// /// <returns>Medaicament</returns>
        public Medicament FindExisted(int id)
        {
            Medicament med = Db.Meds.Find(id);
            Db.Entry(med).State = System.Data.Entity.EntityState.Modified;
            return med;
        }
    }
}

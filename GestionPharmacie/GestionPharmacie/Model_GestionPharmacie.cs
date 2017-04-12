using System;
using System.Data.Entity;
using System.Linq;
using GestionPharmacie.Entities;
namespace GestionPharmacie
{


    public class Model_GestionPharmacie : DbContext
    {
        // Your context has been configured to use a 'Model_GestionPharmacie' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GestionPharmacie.Model_GestionPharmacie' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model_GestionPharmacie' 
        // connection string in the application configuration file.
        public Model_GestionPharmacie()
            : base("name=Model_GestionPharmacie")
        {
        }

        public virtual DbSet<Laboratory> Labos { get; set; }
        public virtual DbSet<Medicament> Meds { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Provider> Provider {get;set;}
        public virtual DbSet<User> Users { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
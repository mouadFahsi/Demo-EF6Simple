namespace ConsoleAppTP4
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelStagiaire : DbContext
    {
        
        public ModelStagiaire()
            : base("name=ModelStagiaire")
        {
        }
        public virtual DbSet<Stagiaire> Stagiaires { get; set; }
        public virtual DbSet<Groupe> Groupes { get; set; }

    }

    
}
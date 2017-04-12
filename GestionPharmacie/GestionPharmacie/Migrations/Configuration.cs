namespace GestionPharmacie.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GestionPharmacie.Model_GestionPharmacie>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(GestionPharmacie.Model_GestionPharmacie context)
        {
            //  This method will be called after migrating to the latest version.
            //context.Users.AddOrUpdate(
            //    new Entities.User
            //    {
            //        UserName = "admin",
            //        PassWord = "admin",
            //    }
            //    );
        }
    }
}

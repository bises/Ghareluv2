namespace RegistrationPortal.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RegistrationPortal.Models.RegistrationPortalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RegistrationPortal.Models.RegistrationPortalContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.People.AddOrUpdate(x => x.PersonId,
                new Person()
                {
                    PersonId = 1,
                    FirstName = "Bishesh",
                    LastName = "Acharya",
                    Address = "690 E Lavaca St Beaumont Tx",
                    CitizenshipNumber = "80415",
                    BirthDate = new DateTime(1990, 7, 12)
                },
                new Person()
                {
                    PersonId = 2,
                    FirstName = "Bibhor",
                    LastName = "Acharya",
                    Address = "Kathmandu Satdobato",
                    CitizenshipNumber = "80417",
                    BirthDate = new DateTime(1995, 11, 12)
                });
        }
    }
}

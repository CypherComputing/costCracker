namespace CostCracker.Migrations
{
    using Models.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CostCracker.Models.GeneralContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CostCracker.Models.GeneralContext context)
        {
            var Users = new List<Person>
            {
            new Person{FirstName="Thomas",LastName="Peters" },
           new Person{FirstName="Elizabeth",LastName="Peters" }
            };
            Users.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

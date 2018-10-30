using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CostCracker.Models.Entities
{
    public class InitialSeeder : System.Data.Entity.DropCreateDatabaseIfModelChanges<GeneralContext>
    {
        protected override void Seed(GeneralContext context)
        {
            var Users = new List<Person>
            {
            new Person{FirstName="Thomas",LastName="Peters" },
           new Person{FirstName="Elizabeth",LastName="Peters" }
            };
            Users.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();
        }
    }
}

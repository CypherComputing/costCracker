using CostCracker.Models.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace CostCracker.Models
{
    public class GeneralContext:DbContext
    {
        public GeneralContext() : base("GeneralConnection")
        {
        }

        public DbSet<Person> Persons { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
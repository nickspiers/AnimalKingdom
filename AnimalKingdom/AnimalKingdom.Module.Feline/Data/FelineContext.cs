using System.Data.Entity;
using AnimalKingdom.Core.Data;
using AnimalKingdom.Module.Feline.Domain;

namespace AnimalKingdom.Module.Feline.Data
{
    public class FelineContext : KingdomContext
    {
        public DbSet<Cat> Cats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Cat>().ToTable("Cats");

            base.OnModelCreating(modelBuilder);
        }
    }
}
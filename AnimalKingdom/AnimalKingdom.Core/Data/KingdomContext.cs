using System.Data.Entity;
using AnimalKingdom.Domain;

namespace AnimalKingdom.Core.Data
{
    public class KingdomContext : DbContext
    {
        public KingdomContext() : base("KingdomConnection")
        {
        }

        public DbSet<AnimalType> AnimalTypes { get; set; }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Animal>().ToTable("Animals");
            modelBuilder.Entity<AnimalType>().ToTable("AnimalTypes");

            base.OnModelCreating(modelBuilder);
        }
    }
}
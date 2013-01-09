using System.Data.Entity.Migrations;
using AnimalKingdom.Domain;
using AnimalKingdom.Module.Feline.Data;

namespace AnimalKingdom.Module.Feline.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FelineContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FelineContext context)
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

            context.AnimalTypes.AddOrUpdate(x => x.Name,
                                            new AnimalType
                                                {
                                                    Name = "Cat"
                                                },
                                            new AnimalType
                                                {
                                                    Name = "Tiger"
                                                });
        }
    }
}
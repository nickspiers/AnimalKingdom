namespace AnimalKingdom.Module.Feline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FelineSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cats",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        TailLength = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Animals", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cats", new[] { "Id" });
            DropForeignKey("dbo.Cats", "Id", "dbo.Animals");
            DropTable("dbo.Cats");
        }
    }
}

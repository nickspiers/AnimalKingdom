namespace AnimalKingdom.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeToCoreDomain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animals", "NumberOfLegs", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Animals", "NumberOfLegs");
        }
    }
}

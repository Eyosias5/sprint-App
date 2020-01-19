namespace SprintOApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stillnaming : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SpringAccesses", newName: "SprintAccesses");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.SprintAccesses", newName: "SpringAccesses");
        }
    }
}

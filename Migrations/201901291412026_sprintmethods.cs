namespace SprintOApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sprintmethods : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sprints", "SpringAccessId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sprints", "SpringAccessId");
        }
    }
}

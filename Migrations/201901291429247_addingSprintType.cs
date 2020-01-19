namespace SprintOApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingSprintType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sprints", "SprintTypeId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sprints", "SprintTypeId");
        }
    }
}

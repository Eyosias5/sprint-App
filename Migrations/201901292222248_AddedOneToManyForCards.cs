namespace SprintOApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOneToManyForCards : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cards", "SprintId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cards", "SprintId");
            AddForeignKey("dbo.Cards", "SprintId", "dbo.Sprints", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cards", "SprintId", "dbo.Sprints");
            DropIndex("dbo.Cards", new[] { "SprintId" });
            DropColumn("dbo.Cards", "SprintId");
        }
    }
}

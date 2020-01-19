namespace SprintOApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingspelling : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sprints", "SpringAccess_Id", "dbo.SpringAccesses");
            DropIndex("dbo.Sprints", new[] { "SpringAccess_Id" });
            DropColumn("dbo.Sprints", "SprintAccessId");
            RenameColumn(table: "dbo.Sprints", name: "SpringAccess_Id", newName: "SprintAccessId");
            AlterColumn("dbo.Sprints", "SprintAccessId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Sprints", "SprintAccessId");
            AddForeignKey("dbo.Sprints", "SprintAccessId", "dbo.SpringAccesses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sprints", "SprintAccessId", "dbo.SpringAccesses");
            DropIndex("dbo.Sprints", new[] { "SprintAccessId" });
            AlterColumn("dbo.Sprints", "SprintAccessId", c => c.Byte());
            RenameColumn(table: "dbo.Sprints", name: "SprintAccessId", newName: "SpringAccess_Id");
            AddColumn("dbo.Sprints", "SprintAccessId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Sprints", "SpringAccess_Id");
            AddForeignKey("dbo.Sprints", "SpringAccess_Id", "dbo.SpringAccesses", "Id");
        }
    }
}

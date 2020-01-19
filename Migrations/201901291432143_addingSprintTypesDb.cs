namespace SprintOApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingSprintTypesDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SpringAccesses",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        AccessType = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SprintTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Typof = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Sprints", "SpringAccess_Id", c => c.Byte());
            CreateIndex("dbo.Sprints", "SprintTypeId");
            CreateIndex("dbo.Sprints", "SpringAccess_Id");
            AddForeignKey("dbo.Sprints", "SpringAccess_Id", "dbo.SpringAccesses", "Id");
            AddForeignKey("dbo.Sprints", "SprintTypeId", "dbo.SprintTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sprints", "SprintTypeId", "dbo.SprintTypes");
            DropForeignKey("dbo.Sprints", "SpringAccess_Id", "dbo.SpringAccesses");
            DropIndex("dbo.Sprints", new[] { "SpringAccess_Id" });
            DropIndex("dbo.Sprints", new[] { "SprintTypeId" });
            DropColumn("dbo.Sprints", "SpringAccess_Id");
            DropTable("dbo.SprintTypes");
            DropTable("dbo.SpringAccesses");
        }
    }
}

namespace SprintOApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addingthestuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sprints", "SprintAccessId", c => c.Byte(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Sprints", "SprintAccessId");
        }
    }
}

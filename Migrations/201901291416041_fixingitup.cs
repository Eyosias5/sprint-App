namespace SprintOApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class fixingitup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sprints",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
 
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Sprints");
        }
    }
}

namespace SprintOApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeofdatatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SprintAccesses", "AccessType", c => c.String());
            AlterColumn("dbo.SprintTypes", "Typof", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SprintTypes", "Typof", c => c.Byte(nullable: false));
            AlterColumn("dbo.SprintAccesses", "AccessType", c => c.Byte(nullable: false));
        }
    }
}

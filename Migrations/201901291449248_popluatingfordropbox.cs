namespace SprintOApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popluatingfordropbox : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO SprintAccesses (Id,AccessType) VALUES(1,'Private')");
            Sql("Insert INTO SprintAccesses (Id,AccessType) VALUES(2,'Public')");
            Sql("Insert INTO SprintTypes (Id,Typof) VALUES(1,'General')");
            Sql("Insert INTO SprintTypes (Id,Typof) VALUES(2,'Software Development')");
        }
        
        public override void Down()
        {
        }
    }
}

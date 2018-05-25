namespace ProsumerDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProsumerInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProducedkW = c.Int(nullable: false),
                        ConsumedkW = c.Int(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProsumerInfoes");
        }
    }
}

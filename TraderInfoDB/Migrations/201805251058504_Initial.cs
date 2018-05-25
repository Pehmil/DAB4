namespace TraderInfoDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TraderInfoes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Token = c.Int(nullable: false),
                        BitCoin = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TraderInfoes");
        }
    }
}

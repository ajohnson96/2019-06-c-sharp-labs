namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHair3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hair",
                c => new
                    {
                        HairID = c.Int(nullable: false, identity: true),
                        HairColour = c.String(),
                        HairLength = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HairID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hair");
        }
    }
}

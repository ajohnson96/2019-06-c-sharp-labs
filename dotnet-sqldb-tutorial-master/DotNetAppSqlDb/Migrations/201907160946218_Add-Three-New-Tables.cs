namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddThreeNewTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskID = c.Int(nullable: false, identity: true),
                        TaskDescription = c.String(maxLength: 50),
                        Done = c.Boolean(),
                        DateStarted = c.DateTime(storeType: "date"),
                        DateCompleted = c.DateTime(storeType: "date"),
                        Category = c.Int(),
                        UserID = c.Int(),
                        Deadline = c.DateTime(storeType: "date"),
                        Category1_CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.TaskID)
                .ForeignKey("dbo.Categories", t => t.Category1_CategoryID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.Category1_CategoryID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "UserID", "dbo.Users");
            DropForeignKey("dbo.Tasks", "Category1_CategoryID", "dbo.Categories");
            DropIndex("dbo.Tasks", new[] { "Category1_CategoryID" });
            DropIndex("dbo.Tasks", new[] { "UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.Tasks");
            DropTable("dbo.Categories");
        }
    }
}

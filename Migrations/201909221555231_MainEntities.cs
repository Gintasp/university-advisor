namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MainEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculty",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        University_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.University", t => t.University_Id)
                .Index(t => t.University_Id);
            
            CreateTable(
                "dbo.StudyProgram",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Faculty_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculty", t => t.Faculty_Id)
                .Index(t => t.Faculty_Id);
            
            CreateTable(
                "dbo.Review",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Rating = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        StudyProgram_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.StudyProgram", t => t.StudyProgram_Id)
                .Index(t => t.UserId)
                .Index(t => t.StudyProgram_Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.University",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faculty", "University_Id", "dbo.University");
            DropForeignKey("dbo.StudyProgram", "Faculty_Id", "dbo.Faculty");
            DropForeignKey("dbo.Review", "StudyProgram_Id", "dbo.StudyProgram");
            DropForeignKey("dbo.Review", "UserId", "dbo.User");
            DropIndex("dbo.Review", new[] { "StudyProgram_Id" });
            DropIndex("dbo.Review", new[] { "UserId" });
            DropIndex("dbo.StudyProgram", new[] { "Faculty_Id" });
            DropIndex("dbo.Faculty", new[] { "University_Id" });
            DropTable("dbo.University");
            DropTable("dbo.User");
            DropTable("dbo.Review");
            DropTable("dbo.StudyProgram");
            DropTable("dbo.Faculty");
        }
    }
}

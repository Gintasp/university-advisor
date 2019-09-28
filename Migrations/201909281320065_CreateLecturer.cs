namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLecturer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lecturer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Faculty_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculty", t => t.Faculty_Id)
                .Index(t => t.Faculty_Id);
            
            AddColumn("dbo.Review", "Lecturer_Id", c => c.Int());
            AddColumn("dbo.StudySubject", "Lecturer_Id", c => c.Int());
            CreateIndex("dbo.Review", "Lecturer_Id");
            CreateIndex("dbo.StudySubject", "Lecturer_Id");
            AddForeignKey("dbo.Review", "Lecturer_Id", "dbo.Lecturer", "Id");
            AddForeignKey("dbo.StudySubject", "Lecturer_Id", "dbo.Lecturer", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lecturer", "Faculty_Id", "dbo.Faculty");
            DropForeignKey("dbo.StudySubject", "Lecturer_Id", "dbo.Lecturer");
            DropForeignKey("dbo.Review", "Lecturer_Id", "dbo.Lecturer");
            DropIndex("dbo.StudySubject", new[] { "Lecturer_Id" });
            DropIndex("dbo.Review", new[] { "Lecturer_Id" });
            DropIndex("dbo.Lecturer", new[] { "Faculty_Id" });
            DropColumn("dbo.StudySubject", "Lecturer_Id");
            DropColumn("dbo.Review", "Lecturer_Id");
            DropTable("dbo.Lecturer");
        }
    }
}

namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedStudySubject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudySubject",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Review", "StudySubject_Id", c => c.Int());
            CreateIndex("dbo.Review", "StudySubject_Id");
            AddForeignKey("dbo.Review", "StudySubject_Id", "dbo.StudySubject", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Review", "StudySubject_Id", "dbo.StudySubject");
            DropIndex("dbo.Review", new[] { "StudySubject_Id" });
            DropColumn("dbo.Review", "StudySubject_Id");
            DropTable("dbo.StudySubject");
        }
    }
}

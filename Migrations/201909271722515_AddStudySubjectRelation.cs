namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudySubjectRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudySubject", "StudyProgram_Id", c => c.Int());
            CreateIndex("dbo.StudySubject", "StudyProgram_Id");
            AddForeignKey("dbo.StudySubject", "StudyProgram_Id", "dbo.StudyProgram", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudySubject", "StudyProgram_Id", "dbo.StudyProgram");
            DropIndex("dbo.StudySubject", new[] { "StudyProgram_Id" });
            DropColumn("dbo.StudySubject", "StudyProgram_Id");
        }
    }
}

namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameToCourse : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.StudySubject", newName: "Course");
            RenameColumn(table: "dbo.Review", name: "StudySubject_Id", newName: "Course_Id");
            RenameIndex(table: "dbo.Review", name: "IX_StudySubject_Id", newName: "IX_Course_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Review", name: "IX_Course_Id", newName: "IX_StudySubject_Id");
            RenameColumn(table: "dbo.Review", name: "Course_Id", newName: "StudySubject_Id");
            RenameTable(name: "dbo.Course", newName: "StudySubject");
        }
    }
}

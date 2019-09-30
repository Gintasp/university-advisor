namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubjectId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Review", name: "StudySubject_Id", newName: "StudySubjectId");
            RenameIndex(table: "dbo.Review", name: "IX_StudySubject_Id", newName: "IX_StudySubjectId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Review", name: "IX_StudySubjectId", newName: "IX_StudySubject_Id");
            RenameColumn(table: "dbo.Review", name: "StudySubjectId", newName: "StudySubject_Id");
        }
    }
}

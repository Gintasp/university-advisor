namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePath : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UploadedFiles", "FilePath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UploadedFiles", "FilePath", c => c.String());
        }
    }
}

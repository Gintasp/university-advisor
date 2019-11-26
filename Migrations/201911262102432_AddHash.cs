namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHash : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UploadedFiles", "Hash", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UploadedFiles", "Hash");
        }
    }
}

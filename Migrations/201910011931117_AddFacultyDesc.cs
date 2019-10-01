namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFacultyDesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Faculty", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faculty", "Description");
        }
    }
}

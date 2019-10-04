namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniWebsites : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.University", "Website", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.University", "Website");
        }
    }
}

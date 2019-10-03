namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLecturerReviewFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Review", "Competence", c => c.Int(nullable: false));
            AddColumn("dbo.Review", "Strictness", c => c.Int(nullable: false));
            AddColumn("dbo.Review", "Delivery", c => c.Int(nullable: false));
            AddColumn("dbo.Review", "Interesting", c => c.Int(nullable: false));
            AddColumn("dbo.Review", "Personality", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Review", "Personality");
            DropColumn("dbo.Review", "Interesting");
            DropColumn("dbo.Review", "Delivery");
            DropColumn("dbo.Review", "Strictness");
            DropColumn("dbo.Review", "Competence");
        }
    }
}

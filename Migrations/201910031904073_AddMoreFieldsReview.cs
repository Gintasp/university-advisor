namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreFieldsReview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Review", "OveralRating", c => c.Int(nullable: false));
            AddColumn("dbo.Review", "Salary", c => c.Int(nullable: false));
            AddColumn("dbo.Review", "Difficulty", c => c.Int(nullable: false));
            AddColumn("dbo.Review", "Satisfaction", c => c.Int(nullable: false));
            AddColumn("dbo.Review", "RelevantIndustry", c => c.Boolean(nullable: false));
            AddColumn("dbo.Review", "CareerStartYear", c => c.Int(nullable: false));
            AddColumn("dbo.Review", "Usefulness", c => c.Int(nullable: false));
            AddColumn("dbo.Review", "Interesting", c => c.Int(nullable: false));
            AddColumn("dbo.Review", "TheoryPercentage", c => c.Int(nullable: false));
            AddColumn("dbo.Review", "PracticePercentage", c => c.Int(nullable: false));
            DropColumn("dbo.Review", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Review", "Rating", c => c.Int(nullable: false));
            DropColumn("dbo.Review", "PracticePercentage");
            DropColumn("dbo.Review", "TheoryPercentage");
            DropColumn("dbo.Review", "Interesting");
            DropColumn("dbo.Review", "Usefulness");
            DropColumn("dbo.Review", "CareerStartYear");
            DropColumn("dbo.Review", "RelevantIndustry");
            DropColumn("dbo.Review", "Satisfaction");
            DropColumn("dbo.Review", "Difficulty");
            DropColumn("dbo.Review", "Salary");
            DropColumn("dbo.Review", "OveralRating");
        }
    }
}

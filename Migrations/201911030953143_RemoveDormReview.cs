namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDormReview : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Dormitory_Id", "dbo.Dormitories");
            DropIndex("dbo.Reviews", new[] { "Dormitory_Id" });
            DropColumn("dbo.Reviews", "Dormitory_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Dormitory_Id", c => c.Int());
            CreateIndex("dbo.Reviews", "Dormitory_Id");
            AddForeignKey("dbo.Reviews", "Dormitory_Id", "dbo.Dormitories", "Id");
        }
    }
}

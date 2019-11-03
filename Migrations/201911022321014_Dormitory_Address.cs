namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dormitory_Address : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Street = c.String(),
                        Nr = c.Int(nullable: false),
                        Dormitory_Id = c.Int(),
                        Faculty_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dormitories", t => t.Dormitory_Id)
                .ForeignKey("dbo.Faculties", t => t.Faculty_Id)
                .Index(t => t.Dormitory_Id)
                .Index(t => t.Faculty_Id);
            
            CreateTable(
                "dbo.Dormitories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        University_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Universities", t => t.University_Id)
                .Index(t => t.University_Id);
            
            AddColumn("dbo.Reviews", "Dormitory_Id", c => c.Int());
            CreateIndex("dbo.Reviews", "Dormitory_Id");
            AddForeignKey("dbo.Reviews", "Dormitory_Id", "dbo.Dormitories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Dormitory_Id", "dbo.Dormitories");
            DropForeignKey("dbo.Dormitories", "University_Id", "dbo.Universities");
            DropForeignKey("dbo.Addresses", "Faculty_Id", "dbo.Faculties");
            DropForeignKey("dbo.Addresses", "Dormitory_Id", "dbo.Dormitories");
            DropIndex("dbo.Reviews", new[] { "Dormitory_Id" });
            DropIndex("dbo.Dormitories", new[] { "University_Id" });
            DropIndex("dbo.Addresses", new[] { "Faculty_Id" });
            DropIndex("dbo.Addresses", new[] { "Dormitory_Id" });
            DropColumn("dbo.Reviews", "Dormitory_Id");
            DropTable("dbo.Dormitories");
            DropTable("dbo.Addresses");
        }
    }
}

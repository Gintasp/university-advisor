namespace Advisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
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
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Website = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Faculties",
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
            
            CreateTable(
                "dbo.Lecturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Faculty_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.Faculty_Id)
                .Index(t => t.Faculty_Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Lecturer_Id = c.Int(),
                        StudyProgram_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lecturers", t => t.Lecturer_Id)
                .ForeignKey("dbo.StudyPrograms", t => t.StudyProgram_Id)
                .Index(t => t.Lecturer_Id)
                .Index(t => t.StudyProgram_Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        OveralRating = c.Int(nullable: false),
                        Salary = c.Int(nullable: false),
                        Difficulty = c.Int(nullable: false),
                        Satisfaction = c.Int(nullable: false),
                        RelevantIndustry = c.Boolean(nullable: false),
                        CareerStartYear = c.Int(nullable: false),
                        Usefulness = c.Int(nullable: false),
                        Interesting = c.Int(nullable: false),
                        TheoryPercentage = c.Int(nullable: false),
                        PracticePercentage = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        Competence = c.Int(nullable: false),
                        Strictness = c.Int(nullable: false),
                        Delivery = c.Int(nullable: false),
                        Personality = c.Int(nullable: false),
                        Course_Id = c.Int(),
                        Lecturer_Id = c.Int(),
                        StudyProgram_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .ForeignKey("dbo.Lecturers", t => t.Lecturer_Id)
                .ForeignKey("dbo.StudyPrograms", t => t.StudyProgram_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.Course_Id)
                .Index(t => t.Lecturer_Id)
                .Index(t => t.StudyProgram_Id);
            
            CreateTable(
                "dbo.StudyPrograms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Faculty_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.Faculty_Id)
                .Index(t => t.Faculty_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Password = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Faculties", "University_Id", "dbo.Universities");
            DropForeignKey("dbo.Lecturers", "Faculty_Id", "dbo.Faculties");
            DropForeignKey("dbo.Reviews", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Reviews", "StudyProgram_Id", "dbo.StudyPrograms");
            DropForeignKey("dbo.StudyPrograms", "Faculty_Id", "dbo.Faculties");
            DropForeignKey("dbo.Courses", "StudyProgram_Id", "dbo.StudyPrograms");
            DropForeignKey("dbo.Reviews", "Lecturer_Id", "dbo.Lecturers");
            DropForeignKey("dbo.Reviews", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Courses", "Lecturer_Id", "dbo.Lecturers");
            DropForeignKey("dbo.Addresses", "Faculty_Id", "dbo.Faculties");
            DropForeignKey("dbo.Dormitories", "University_Id", "dbo.Universities");
            DropForeignKey("dbo.Addresses", "Dormitory_Id", "dbo.Dormitories");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.StudyPrograms", new[] { "Faculty_Id" });
            DropIndex("dbo.Reviews", new[] { "StudyProgram_Id" });
            DropIndex("dbo.Reviews", new[] { "Lecturer_Id" });
            DropIndex("dbo.Reviews", new[] { "Course_Id" });
            DropIndex("dbo.Reviews", new[] { "UserId" });
            DropIndex("dbo.Courses", new[] { "StudyProgram_Id" });
            DropIndex("dbo.Courses", new[] { "Lecturer_Id" });
            DropIndex("dbo.Lecturers", new[] { "Faculty_Id" });
            DropIndex("dbo.Faculties", new[] { "University_Id" });
            DropIndex("dbo.Dormitories", new[] { "University_Id" });
            DropIndex("dbo.Addresses", new[] { "Faculty_Id" });
            DropIndex("dbo.Addresses", new[] { "Dormitory_Id" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.StudyPrograms");
            DropTable("dbo.Reviews");
            DropTable("dbo.Courses");
            DropTable("dbo.Lecturers");
            DropTable("dbo.Faculties");
            DropTable("dbo.Universities");
            DropTable("dbo.Dormitories");
            DropTable("dbo.Addresses");
        }
    }
}

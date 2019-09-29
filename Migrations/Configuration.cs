namespace Advisor.Migrations
{
    using Advisor.Model;
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseContext context)
        {
            string dataFolderPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\Migrations\\Data\\";

            PurgeDatabase(context);
            LoadUsers(context, dataFolderPath);
            
        }

        private void LoadUsers(DatabaseContext context, string dataFolderPath)
        {
            var users = File.ReadAllLines(dataFolderPath + "User.csv").Select(
                line => new User()
                {
                    Name = line.Split(',')[0],
                    Email = line.Split(',')[1],
                    Password = "pass"
                }
            ).ToList();
            context.Users.AddRange(users);
            context.SaveChanges();
        }

        private void PurgeDatabase(DatabaseContext context)
        {
            context.Database.ExecuteSqlCommand("DELETE FROM [User]");
            context.Database.ExecuteSqlCommand("DELETE FROM [University]");
            context.Database.ExecuteSqlCommand("DELETE FROM [StudySubject]");
            context.Database.ExecuteSqlCommand("DELETE FROM [StudyProgram]");
            context.Database.ExecuteSqlCommand("DELETE FROM [Review]");
            context.Database.ExecuteSqlCommand("DELETE FROM [Lecturer]");
            context.Database.ExecuteSqlCommand("DELETE FROM [Faculty]");
        }
    }
}

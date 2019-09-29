namespace Advisor.Migrations
{
    using Advisor.Model;
    using System;
    using System.Collections.Generic;
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
            LoadUserReviews(context, dataFolderPath);
        }

        private void LoadUserReviews(DatabaseContext context, string dataFolderPath)
        {
            List<User> userList = DB.Instance.Users.ToList();
            Random rand = new Random();

            var reviews = File.ReadAllLines(dataFolderPath + "Rating.csv").Select(
                line => new Review()
                {
                    Rating = int.Parse(line.Split(',')[1]),
                    Text = line.Split(',')[0],
                    UserId = userList.ElementAt(rand.Next(0, userList.Count)).Id
                }
            ).ToList();
            context.Reviews.AddRange(reviews);
            context.SaveChanges();
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
            context.Database.ExecuteSqlCommand("DELETE FROM [User]; DBCC CHECKIDENT ([User], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [University]; DBCC CHECKIDENT ([University], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [StudySubject]; DBCC CHECKIDENT ([StudySubject], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [StudyProgram]; DBCC CHECKIDENT ([StudyProgram], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Review]; DBCC CHECKIDENT ([Review], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Lecturer]; DBCC CHECKIDENT ([Lecturer], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Faculty]; DBCC CHECKIDENT ([Faculty], RESEED, 0)");
        }
    }
}

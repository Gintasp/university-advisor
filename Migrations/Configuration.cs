namespace Advisor.Migrations
{
    using Advisor.Model;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseContext context)
        {
            PurgeDatabase(context);
            context.Users.Add(new User() { Name = "John Doe", Email = "john@doe.com", Password = "password"});
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

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Advisor.Model
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<StudyProgram> StudyPrograms { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<StudySubject> StudySubjects { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

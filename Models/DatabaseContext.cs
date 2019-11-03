using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Advisor.Models
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<StudyProgram> StudyPrograms { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Dormitory> Dormitories { get; set; }

        public DatabaseContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static DatabaseContext Create()
        {
            return new DatabaseContext();
        }
    }
}

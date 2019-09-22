using System.Data.Entity;

namespace Advisor.Model
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}

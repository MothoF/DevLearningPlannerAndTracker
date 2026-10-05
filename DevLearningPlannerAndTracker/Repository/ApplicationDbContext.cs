using Microsoft.EntityFrameworkCore;

namespace DevLearningPlannerAndTracker.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Users> users => Set<Users>();
        public DbSet<Modules> modules => Set<Modules>();
        public DbSet<Topics> topics => Set<Topics>();
        public DbSet<Concepts> concepts => Set<Concepts>();
        public DbSet<UserTasks> userTasks => Set<UserTasks>();
    }
}

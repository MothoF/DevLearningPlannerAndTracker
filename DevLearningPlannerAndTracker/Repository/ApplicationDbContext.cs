using Microsoft.EntityFrameworkCore;
using DevLearningPlannerAndTracker.Entities;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>()
                .HasKey(
                    u => u.Username
                );
        }
    }
}

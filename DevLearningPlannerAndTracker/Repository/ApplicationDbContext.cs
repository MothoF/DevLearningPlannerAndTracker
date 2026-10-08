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

            //Defining the primary keys for each of the entities
            modelBuilder.Entity<Users>()
                .HasKey(
                    u => new { u.Username }
                );

            modelBuilder.Entity<Modules>()
                .HasKey(
                    m => new { m.ModuleCode }
                );

            modelBuilder.Entity<Topics>()
                .HasKey(
                    t => new { t.TopicId, t.ModuleCode } //Composite primary key TopicId + ModuleCode
                );

            modelBuilder.Entity<Concepts>()
                .HasKey(
                    c => new { c.ConceptId }
                );

            modelBuilder.Entity<UserTasks>()
                .HasKey(
                    ut => new { ut.Username, ut.ConceptId } //Composite primary key Username + ConceptId
                );

            //Defining the relationships between the different entities
            modelBuilder.Entity<UserTasks>()
                .HasOne(ut => ut.user)
                .WithMany(u => u.userTasks)
                .HasForeignKey(ut => new
                {
                    ut.Username,
                    //ut.ConceptId
                });

            modelBuilder.Entity<UserTasks>()
                .HasOne(ut => ut.concept)
                .WithMany(c => c.conceptTasks)
                .HasForeignKey(ut => new
                {
                    //ut.Username,
                    ut.ConceptId
                });

            modelBuilder.Entity<Concepts>()
                .HasOne(c => c.conceptTopic)
                .WithMany(t => t.topicConcepts)
                .HasForeignKey(
                    c => new
                    {
                        c.TopicId,
                        c.ModuleCode
                    }
                );

            modelBuilder.Entity<Topics>()
                .HasOne(t => t.topicModule)
                .WithMany(m => m.moduleTopics)
                .HasForeignKey(
                    t => new
                    {
                        t.ModuleCode
                    }
                );

        }
    }
}

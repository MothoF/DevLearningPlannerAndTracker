using Microsoft.EntityFrameworkCore;

namespace DevLearningPlannerAndTracker.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}

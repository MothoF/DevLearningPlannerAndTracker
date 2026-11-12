using Microsoft.EntityFrameworkCore;

namespace DevLearningPlannerAndTracker.Repository
{
    public static class DbAutoUpdate
    {
        public static void UpdateDb(this WebApplication app)
        {
            using var scope = app.Services.CreateScope(); //Create a temporary sandbox to communicate with the primary DI container for resources
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>(); //Prompt the DI container to generate an ApplicationDBContext object
            dbContext.Database.Migrate(); //Update the database
        }
    }
}

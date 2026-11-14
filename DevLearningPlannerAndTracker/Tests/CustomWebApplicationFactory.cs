using DevLearningPlannerAndTracker.Repository;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection.Extensions;
public class CustomWebApplicationFactory : WebApplicationFactory<Program> { 
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices((context, services) =>
        {
            services.RemoveAll<ApplicationDbContext>();
            services.RemoveAll<IApplicationRepository>();

            services.AddNpgsql<ApplicationDbContext>(context.Configuration.GetConnectionString("DevPlannerTestDb"));
            services.AddSingleton<IApplicationRepository, AppRepository>();
        });
    }
}
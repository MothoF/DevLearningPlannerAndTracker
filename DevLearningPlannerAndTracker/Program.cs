using DevLearningPlannerAndTracker.Repository;
using Microsoft.AspNetCore.Hosting.Builder;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DevPlannerDb"); //Retrieve data source configurations stored in the user secrets
builder.Services.AddNpgsql<ApplicationDbContext>(connectionString); //Register the ApplicationDBContext class to the DI container
builder.Services.AddSingleton<IApplicationRepository, AppRepository>();
var app = builder.Build();
app.UpdateDb(); // Automatically update the database on app start.

app.MapGet("/", () => "Hello World!");

app.Run();

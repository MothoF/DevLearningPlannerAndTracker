using DevLearningPlannerAndTracker.Repository;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DevPlannerDb"); //Retrieve data source configurations stored in the user secrets
builder.Services.AddNpgsql<ApplicationDbContext>(connectionString); //Register the ApplicationDBContext class to the DI container
var app = builder.Build();
app.UpdateDb(); // Automatically update the database on app start.

app.MapGet("/", () => "Hello World!");

app.Run();

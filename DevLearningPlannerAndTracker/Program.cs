using DevLearningPlannerAndTracker.Repository;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DevPlannerDb");
builder.Services.AddNpgsql<ApplicationDbContext>(connectionString);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

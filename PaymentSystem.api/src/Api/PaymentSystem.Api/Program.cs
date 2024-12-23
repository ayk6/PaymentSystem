using PaymentSystem.Application;
using PaymentSystem.Infrastructure;
using PaymentSystem.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add controllers
builder.Services.AddControllers();

// Add Application Services
builder.Services.AddApplicationServices(); // Application katmanı için DI

// Add Infrastructure Services
builder.Services.AddInfrastructureServices(builder.Configuration); // Infrastructure katmanı için DI

var app = builder.Build();

// Configure middleware
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.Extensions.DependencyInjection;
using HealthBridge_TechCursaders.Data.Seed;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        SeedData.Initialize(services);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[ERROR] Seed data failed: {ex.Message}");
    }
}

app.Run();

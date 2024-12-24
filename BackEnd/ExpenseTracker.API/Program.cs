using ExpenseTracker.Infrastructure.Data;
using ExpenseTracker.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();
ConfigureMiddleware(app);

app.Run();

void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    services.AddOpenApi();
    services.AddControllers();
    services.AddDbContext<ExpenseTrackerDbContext>(options =>
        options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    services.AddScoped<IUserRepository, UserRepository>();
}

void ConfigureMiddleware(WebApplication app)
{
    app.UseAuthorization();
    app.MapControllers();
}


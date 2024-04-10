using Microsoft.EntityFrameworkCore;
using Web.API.Application.Repositories;
using Web.API.Models.Context;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        var conn = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<APIDbContext>(options => options.UseNpgsql(conn));
        builder.Services.AddScoped<ICarRepository, CarRepository>();

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        //Migrate if necesary when app runs.
        using (var scope = app.Services.CreateScope())
        {
            var datContext = scope.ServiceProvider.GetRequiredService<APIDbContext>();
            datContext.Database.Migrate();
        }

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
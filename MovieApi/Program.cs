
using Microsoft.EntityFrameworkCore;
using MovieApi.Extensions;

namespace MovieApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddDbContext<MovieApiContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // From Metod 2: Separat Seed-metod, Föreläsning Entity Framework CORE-Seeding - NOTE: Removed await since the Seed-method is synchronous and void
            using (var scope = app.Services.CreateScope())
            {
                var context =
                    scope.ServiceProvider.GetRequiredService<MovieApiContext>();
                SeedData.Seed(context);
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

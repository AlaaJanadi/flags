using Flags.Models;
using Flags.Services;

namespace Flags
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllers();

            builder.Services.Configure<CountryDatabaseSettings>(
                               builder.Configuration.GetSection("CountryDatabase"));

            builder.Services.AddScoped<ICountryService,CountryService>();

            var app = builder.Build();
            // Configure the HTTP request pipeline.
            app.UseHttpsRedirection();
            app.MapControllers();
            app.Run();
        }
    }
}
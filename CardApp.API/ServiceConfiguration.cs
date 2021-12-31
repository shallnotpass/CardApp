using CardApp.BuisnessLayer;
using CardApp.BuisnessLayer.Contracts;
using DataLayer;
using Microsoft.EntityFrameworkCore;

namespace CardApp.API
{
    public static class ServiceConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICardService, CardService>();
            services.AddTransient<IDataAccess, DataAccess>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));
        }
    }
}

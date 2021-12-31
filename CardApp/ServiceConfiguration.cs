using DataLayer;
using Microsoft.EntityFrameworkCore;

namespace CardApp
{
    public static class ServiceConfiguration
    {
        public static void  ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));
        }
    }
}

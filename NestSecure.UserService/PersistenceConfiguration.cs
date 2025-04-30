using Microsoft.EntityFrameworkCore;
using NestSecure.UserService.Core;

namespace NestSecure.UserService
{
    public static class PersistenceConfiguration
    {
        public static void AddPersistenceConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            // Register the DbContext with the connection string
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}

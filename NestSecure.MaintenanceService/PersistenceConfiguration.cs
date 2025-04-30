using Microsoft.EntityFrameworkCore;
using NestSecure.ComplaintService.Core;

namespace NestSecure.MaintenanceService
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

using NestSecure.MaintenanceService.Core;
using NestSecure.MaintenanceService.Repositories;

namespace NestSecure.MaintenanceService
{
    public static class RepositoryConfiguration
    {
        public static void AddRepositoryConfiguration(this IServiceCollection services)
        {
            // Register repository and unit of work interfaces with their implementations
            services.AddScoped<IMaintenanceRepo, MaintenanceRepo>();

        }
    }
}

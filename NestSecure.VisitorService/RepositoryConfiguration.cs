using NestSecure.VisitorService.Core;
using NestSecure.VisitorService.Repositories;

namespace NestSecure.VisitorService
{
    public static class RepositoryConfiguration
    {
        public static void AddRepositoryConfiguration(this IServiceCollection services)
        {
            // Register repository and unit of work interfaces with their implementations
            services.AddScoped<IVisitorRepo, VisitorRepo>();

        }
    }
}

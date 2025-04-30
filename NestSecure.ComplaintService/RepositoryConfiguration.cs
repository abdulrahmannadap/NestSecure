using NestSecure.AuthService.Repositories;
using NestSecure.ComplaintService.Core;

namespace NestSecure.ComplaintService
{
    public static class RepositoryConfiguration
    {
        public static void AddRepositoryConfiguration(this IServiceCollection services)
        {
            // Register repository and unit of work interfaces with their implementations
            services.AddScoped<IComplaintRepo, ComplaintRepo>();

        }
    }
}

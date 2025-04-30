using NestSecure.UserService.Core;
using NestSecure.UserService.Repositories;

namespace NestSecure.UserService
{
    public static class RepositoryConfiguration
    {
        public static void AddRepositoryConfiguration(this IServiceCollection services)
        {
            // Register repository and unit of work interfaces with their implementations
            services.AddScoped<IHouseOwnerRepo, HouseOwnerRepo>();
            services.AddScoped<ISecretaryRepo, SecretaryRepo>();
            services.AddScoped<ISecurityGuardRepo, SecurityGuardRepo>();
            services.AddScoped<ISocietyRepo, SocietyRepo>();

        }
    }
}

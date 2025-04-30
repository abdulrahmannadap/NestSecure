using NestSecure.AuthService.Core;
using NestSecure.AuthService.Repositories;

namespace NestSecure.AuthService
{
    public static class RepositoryConfiguration
    {
        public static void AddRepositoryConfiguration(this IServiceCollection services)
        {
            // Register repository and unit of work interfaces with their implementations
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IRoleRepo, RoleRepo>();



        }
    }
}

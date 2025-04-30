namespace NestSecure.AuthService
{
    public static class DependencyInjection
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register the various service configurations
            services.AddPersistenceConfiguration(configuration);  // DbContext configuration
            services.AddRepositoryConfiguration();                  // Repository and UnitOfWork configuration
            services.AddMappingConfiguration();                     // AutoMapper configuration


        }
    }
}

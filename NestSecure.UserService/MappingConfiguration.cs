// MappingConfiguration.cs
namespace NestSecure.UserService
{
    public static class MappingConfiguration
    {
        public static void AddMappingConfiguration(this IServiceCollection services)
        {
            // Register AutoMapper with assemblies
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}

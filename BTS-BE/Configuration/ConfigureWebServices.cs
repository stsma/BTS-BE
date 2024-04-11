namespace BTS_BE.Configuration
{
    public static class ConfigureWebServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
        {
            //add scopes here for DI
            return services;
        }
    }
}

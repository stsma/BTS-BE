using BTS.Core.Interfaces;
using BTS.Core.Services;

namespace BTS_BE.Configuration
{
    public static class ConfigureWebServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
        {
            //add scopes here for DI
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}

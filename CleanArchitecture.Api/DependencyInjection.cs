using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;

namespace CleanArchitecture.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            // Register application services here
            // Example: services.AddScoped<IMyService, MyService>();

            services.AddApplicationDI()
                .AddInfrastructureDI();

            return services;
        }
    }
}

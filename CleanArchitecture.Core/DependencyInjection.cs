using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection CoreDI(this IServiceCollection services)
        {
            // Register application services here
            // Example: services.AddScoped<IMyService, MyService>();
            return services;
        }
    }
}

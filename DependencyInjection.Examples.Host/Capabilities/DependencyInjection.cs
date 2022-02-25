using DependencyInjection.Examples.Host.Interfaces;
using DependencyInjection.Examples.Host.Repositories;
using DependencyInjection.Examples.Host.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Examples.Host.Capabilities
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            return services
                .AddScoped<INumberRepository, InMemoryNumberRepository>() // Dabar aplikacija naudoja In Memory technologija, o jei noreciau pakeisti i SQL tada uzkomenticiau sita eilute ir atkomenticiau zemiau esancia o daugiau nieko aplikacijoje nereiktu keisti
                //.AddScoped<INumberRepository, SqlNumberRepository>()

                .AddScoped<INumberService, NumberService>();
        }
    }
}

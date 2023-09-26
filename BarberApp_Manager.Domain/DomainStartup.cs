using BarberApp_Manager.Domain.Cabeleireiro;
using BarberApp_Manager.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BarberApp_Manager.Domain
{
    public static class DomainStartup
    {
        public static IServiceCollection AddDomainRegister(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICabeleireiroDomain, CabeleireiroDomain>();

            serviceCollection.AddRepositoryRegister();

            return serviceCollection;
        }
    }
}
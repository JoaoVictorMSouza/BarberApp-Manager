using Microsoft.Extensions.DependencyInjection;

namespace BarberApp_Manager.Repository
{
    public static class RepositoryStartup
    {
        public static IServiceCollection AddRepositoryRegister(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}
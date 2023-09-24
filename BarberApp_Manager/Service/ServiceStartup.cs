using AutoMapper;
using BarberApp_Manager.Service.Mapper;

namespace BarberApp_Manager.Service
{
    public static class ServiceStartup
    {
        public static IServiceCollection AddServiceRegister(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<CustomMapper>();

            return serviceCollection;
        }
    }
}

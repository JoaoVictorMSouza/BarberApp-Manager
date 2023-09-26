using BarberApp_Manager.Domain;
using BarberApp_Manager.Service;

namespace BarberApp_Manager
{
    public static class PresentationStartup
    {
        public static IServiceCollection AddPresentationRegister(this IServiceCollection serviceCollection) 
        {
            serviceCollection.AddAutoMapper(typeof(PresentationStartup));

            serviceCollection.AddServiceRegister();
            serviceCollection.AddDomainRegister();

            return serviceCollection;
        }
    }
}

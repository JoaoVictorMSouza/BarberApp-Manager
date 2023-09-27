using BarberApp_Manager.Repository.SqlConfigurations.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BarberApp_Manager.Repository
{
    public static class RepositoryStartup
    {
        public static IServiceCollection AddRepositoryRegister(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<SqlDataContext>((serviceProvider, optionsBuilder) =>
            {
                IConfiguration configuration = serviceProvider.GetRequiredService<IConfiguration>();
                string? defaultConnection = SqlDataContext.GetConnectionEnviroment() ?? configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(defaultConnection);
            });

            return serviceCollection;
        }
    }
}
using Data;
using DataRepositorio;
using Microsoft.Extensions.DependencyInjection;
using Negocio;
using Negocio.Interfaz;

namespace Transversal.Registrar
{
    public static class IocRegister
    {

        public static  IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterRepository(services);

            AddRegistrationNegocio(services);
            return services;
        }

        private static IServiceCollection AddRegisterRepository(IServiceCollection services)
        {
            services.AddTransient<IRepositorioHotel, DHotel>();
            return services;
        }

        private static IServiceCollection AddRegistrationNegocio(this IServiceCollection services)
        {
            services.AddScoped<IBHotel, BHotel>();

            return services;
        }
    }
}

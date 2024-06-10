using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tarker.Booking.External
{
    /// <summary>
    /// Clase static para Servicio de injección de dependencias.
    /// </summary>
    /// <remarks>
    /// Autor: Gonzalo Mata
    /// Fecha: 10/06/2024
    /// </remarks>
    public static class DependencyInjectionService
    {
        /// <summary>
        /// Método static para retornar IServiceCollection
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddExternal(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}

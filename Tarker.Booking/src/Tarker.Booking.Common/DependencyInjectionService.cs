using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Common
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
        /// <returns></returns>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 10/06/2024
        /// </remarks>
        public static IServiceCollection AddAddCommon(this IServiceCollection services)
        {
            return services;
        }
    }
}

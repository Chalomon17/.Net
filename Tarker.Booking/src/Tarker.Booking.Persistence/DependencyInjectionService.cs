using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Application.Interfaces;
using Tarker.Booking.Persistence.DataBase;

namespace Tarker.Booking.Persistence
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
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {

            // 1. Método que registra DataBaseService como un servicio de DbContext
            // en el contenedor de inyección de dependencias.
            // 2. option.UseSqlServer configura EntityFramework Core para usar SQL.
            // 3. configuration[] obtiene la cadena de conexión de la configuración
            // de la aplicación. Ejemplo, appsettings.json.
            services.AddDbContext<DataBaseService>(option =>
            option.UseSqlServer(configuration["SQLConnectionStrings"]));

            // 1. Método de AddScope registra IDataBaseService y DataBaseService en el
            // contenedor de inyección de dependencias.
            // 2. IDataService es una interfaz y DataBaseService es su implementación concreta.
            // 3. AddScope indica que una nueva instancia del servicio se creará una vez por solicitud.
            // NOTA: Se puede crear mas interfaces con el nombre de su servicio.
            services.AddScoped<IDataBaseService, DataBaseService>();

            return services;
        }
    }
}

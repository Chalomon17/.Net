using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Tarker.Booking.Application.Configuration;
using Tarker.Booking.Application.DataBase.Usuario.Commands;

namespace Tarker.Booking.Application
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
        /// Método static para retornar IServiceCollection.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 10/06/2024
        /// </remarks>
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // 1. Objeto para la configuración del mapeo con AutoMapper.
            var mapper = new MapperConfiguration(config =>
            {
                // 2. Es una clase que define las reglas de mapeo entre los objetos.
                // 3. AddProfile añade estas reglas al mapeador.
                config.AddProfile(new MapperProfile());
            });

            // 4. Registro del mapeador como un servicio singleton.
            // 5 .Un servicio singleton es una instancia única que se crea una vez y se reutiliza
            // en toda la aplicación.
            // 6. mapper.CreateMapper() crea una instancia de IMapper utilizando la configuración
            // definida anteriormente.
            services.AddSingleton(mapper.CreateMapper());
            // 7. services.AddTransient<ICommand, Command>(): Tiene que estar la interfaz con su clase
            // de implementación correspondiente.
            services.AddTransient<IUsuarioCommand, UsuarioCommand>();

            return services;
        }
    }
}

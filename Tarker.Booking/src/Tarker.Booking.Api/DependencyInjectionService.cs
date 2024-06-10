namespace Tarker.Booking.Api
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
        public static IServiceCollection AddWebApi(this IServiceCollection services)
        {
            return services;
        }
    }
}

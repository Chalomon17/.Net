using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Tarker.Booking.Application.DataBase.Usuario.Commands.EliminarUsuario
{
    /// <summary>
    /// Clase de implementación EliminarUsuarioCommand
    /// La interfaz va relacionado con la implementación correspondiente
    /// </summary>
    /// <remarks>
    /// Autor: Gonzalo Mata
    /// Fecha: 13/06/2024
    /// </remarks>
    public class EliminarUsuarioCommand : IEliminarUsuarioCommand
    {
        /// <summary>
        /// Invocación al servicio de Base de datos.
        /// </summary>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 13/06/2024
        /// </remarks>
        private readonly IDataBaseService _dataBaseService;

        /// <summary>
        /// Constructor de la clase EliminarUsuarioCommand aplicando inyección de dependencias.
        /// </summary>
        /// <param name="dataBaseService"></param>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 13/06/2024
        /// </remarks>
        public EliminarUsuarioCommand(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        /// <summary>
        /// Método asíncrono para eliminar un UsuarioModel
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>Retorna true o false</returns>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 13/06/2024
        /// </remarks>
        public async Task<bool> Execute(int idUsuario)
        {
            // 1. Consulta UsuarioEntity el primero que encuentre y hace un lambda para comparar el idUsario de la entidad
            // con el valor del parámetro del método.
            var entity = await _dataBaseService.Usuario.FirstOrDefaultAsync(x => x.IdUsuario == idUsuario);

            // 2. Se compara si el valor viene nulo y si es así retorna en false
            if(entity == null)
                return false;

            // 3. Si el valor es diferente de false, entonces se prosigue a eliminar el usuario mediante id.
            // 4. Remove(entity) significa el valor del id a eliminar.
            _ = _dataBaseService.Usuario.Remove(entity);

            // 5. Se guardan cambios de la ejecución
            return await _dataBaseService.SaveAsync();
        }


    }
}

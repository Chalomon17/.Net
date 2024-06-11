using AutoMapper;
using Tarker.Booking.Domain.Entities.Usuario;

namespace Tarker.Booking.Application.DataBase.Usuario.Commands.CrearUsuario
{
    /// <summary>
    /// Clase de implementación UsuarioCommand
    /// La interfaz va relacionado para acceder a la implementación correspondiente
    /// </summary>
    /// <remarks>
    /// Autor: Gonzalo Mata
    /// Fecha: 10/06/2024
    /// </remarks>
    public class CrearUsuarioCommand : ICrearUsuarioCommand
    {
        /// <summary>
        /// Invocación al servicio de Base de datos.
        /// </summary>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 10/06/2024
        /// </remarks>
        private readonly IDataBaseService _dataBaseService;

        /// <summary>
        /// Invocación al servicio de Mapper.
        /// </summary>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 10/06/2024
        /// </remarks>
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor de la clase UsuarioCommand aplicando inyección de dependencias.
        /// </summary>
        /// <param name="dataBaseService"></param>
        /// <param name="mapper"></param>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 10/06/2024
        /// </remarks>
        public CrearUsuarioCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        /// <summary>
        /// Método asíncrono para guardar los datos del UsuarioModel
        /// </summary>
        /// <param name="usuarioModel"></param>
        /// <returns>Retorna el objeto de UsuarioModel</returns>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 10/06/2024
        /// </remarks>
        public async Task<CrearUsuarioModel> Execute(CrearUsuarioModel usuarioModel)
        {

            // 1. _mapper: Se llama al servicio de mapeo
            // 2. .Map<UsuarioEntity>: Modelo que se convertirá en una entidad 
            // 3. (usuarioModel): El modelo que se quiere convertir a una entidad
            var entity = _mapper.Map<UsuarioEntity>(usuarioModel);

            // 4. await: Se ocupa porque el método es asíncrono
            // 5. _dataBaseService: Se llama al domain de la Base de datos
            // 6. .Usuario: Se llama a la entidad Usuario que representa a la tabla
            // 7. .AddAsync(entity): Se le pasa la entidad a guardar o insertar
            await _dataBaseService.Usuario.AddAsync(entity);

            // 8. await: Se ocupa porque el método es asíncrono
            // 9. _dataBaseService: Se llama al domain de la Base de datos
            // 10. .SaveAsync(): Se guardan los cambios
            await _dataBaseService.SaveAsync();

            // 11. usuarioModel: Se retornar el modelo para mostrar lo guardado
            return usuarioModel;
        }

    }
}

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Domain.Entities.Usuario;

namespace Tarker.Booking.Application.DataBase.Usuario.Commands.ActualizarUsuario
{
    /// <summary>
    /// Clase de implementación ActualizarUsuarioCommand
    /// La interfaz va relacionado con la implementación correspondiente
    /// </summary>
    /// <remarks>
    /// Autor: Gonzalo Mata
    /// Fecha: 10/06/2024
    /// </remarks>
    public class ActualizarUsuarioCommand : IActualizarUsuarioCommand
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
        /// Constructor de la clase ActualizarUsuarioCommand aplicando inyección de dependencias.
        /// </summary>
        /// <param name="dataBaseService"></param>
        /// <param name="mapper"></param>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 10/06/2024
        /// </remarks>
        public ActualizarUsuarioCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        /// <summary>
        /// Método asíncrono para guardar los datos del UsuarioModel
        /// </summary>
        /// <param name="actualizarUsuarioModel"></param>
        /// <returns>Retorna el objeto de ActualizarUsuarioModel</returns>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 10/06/2024
        /// </remarks>
        public async Task<ActualizarUsuarioModel> Execute(ActualizarUsuarioModel actualizarUsuarioModel)
        {
            var entity = _mapper.Map<UsuarioEntity>(actualizarUsuarioModel);
            // 1. Aquí con se ocupa await porque Update no es un método asíncrono.
            _dataBaseService.Usuario.Update(entity);
            // 2. .SaveAsync(): Si es un método asíncrono.
            await _dataBaseService.SaveAsync();
            return actualizarUsuarioModel;
        }

        /// <summary>
        /// Método asíncrono para actualizar el campo password.
        /// </summary>
        /// <param name="actualizarUsuarioPasswordModel"></param>
        /// <returns>Retorna true o false</returns>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 13/06/2024
        /// </remarks>
        public async Task<bool> ExecutePassword(ActualizarUsuarioPasswordModel actualizarUsuarioPasswordModel)
        {
            // 1. Se realiza una búsqueda hacia la base de datos para obtener los datos del usuario mediante el id del usuario para encontrar
            // el primero por default 
            var entity = await _dataBaseService.Usuario.FirstOrDefaultAsync(x => x.IdUsuario == actualizarUsuarioPasswordModel.IdUsuario);

            // 2. Se realiza una validación o condición para saber si viene nulo, si es así retornar false
            if (entity == null)
                return false;

            // 3. Se setea el valor del modelo con la propiedad de la entidad a actualizar
            entity.Password = actualizarUsuarioPasswordModel.Password;

            // 4. Se guardan los cambios de forma asíncrona.
            return await _dataBaseService.SaveAsync();

        }
    }
}

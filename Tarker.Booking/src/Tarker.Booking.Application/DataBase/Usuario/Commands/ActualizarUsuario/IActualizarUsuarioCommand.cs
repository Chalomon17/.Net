using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DataBase.Usuario.Commands.ActualizarUsuario
{
    /// <summary>
    /// Interfaz pública de IActualizarUsuarioCommand (domain)
    /// </summary>
    /// <remarks>
    /// Autor: Gonzalo Mata
    /// Fecha: 10/06/2024
    /// </remarks>
    public interface IActualizarUsuarioCommand
    {
        /// <summary>
        /// Interfaz Execute que va estar relacionado a su implementación correspondiente
        /// </summary>
        /// <param name="actualizarUsuarioModel"></param>
        /// <returns>Retorna el objeto de UsuarioModel</returns>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 10/06/2024
        /// </remarks>
        Task<ActualizarUsuarioModel> Execute(ActualizarUsuarioModel actualizarUsuarioModel);
    }
}

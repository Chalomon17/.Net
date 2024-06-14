using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DataBase.Usuario.Commands.EliminarUsuario
{
    /// <summary>
    /// Interfaz pública de IEliminarUsuarioCommand (domain)
    /// </summary>
    /// <remarks>
    /// Autor: Gonzalo Mata
    /// Fecha: 13/06/2024
    /// </remarks>
    public interface IEliminarUsuarioCommand
    {
        /// <summary>
        /// Interfaz Execute que va estar relacionado a su implementación correspondiente
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>Retorna true o false</returns>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 13/06/2024
        /// </remarks>
        Task<bool> Execute(int idUsuario);

    }
}

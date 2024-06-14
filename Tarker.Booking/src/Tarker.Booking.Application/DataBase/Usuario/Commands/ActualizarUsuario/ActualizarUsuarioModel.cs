using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Application.DataBase.Usuario.Commands.ActualizarUsuario
{
    /// <summary>
    /// Modelo ActualizarUsuarioModel.
    /// </summary>
    /// <remarks>
    /// Autor: Gonzalo Mata
    /// Fecha: 10/06/2024
    /// </remarks>
    public class ActualizarUsuarioModel
    {

        /// <summary>
        /// Id del Usuario
        /// </summary>
        public int IdUsuario { get; set; }
        /// <summary>
        /// Nombre del Usuario
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Apellido paterno del Usuario
        /// </summary>
        public string ApellidoPaterno { get; set; }
        /// <summary>
        /// Apellido materno del Usuario
        /// </summary>
        public string ApellidoMaterno { get; set; }
        /// <summary>
        /// Password del UsuarioW
        /// </summary>
        public string Password { get; set; }
    }

    public class ActualizarUsuarioPasswordModel
    {
        /// <summary>
        /// Id del Usuario
        /// </summary>
        public int IdUsuario { get; set; }
        /// <summary>
        /// Nombre del Usuario
        /// </summary>
        public string Password { get; set; }
    }
}


namespace Tarker.Booking.Application.DataBase.Usuario.Commands.CrearUsuario
{
    /// <summary>
    /// Modelo CrearUsuarioModel.
    /// </summary>
    /// <remarks>
    /// Autor: Gonzalo Mata
    /// Fecha: 10/06/2024
    /// </remarks>
    public class CrearUsuarioModel
    {
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
}


namespace Tarker.Booking.Application.DataBase.Usuario.Commands.CrearUsuario
{
    /// <summary>
    /// Interfaz pública de IUsuarioCommand (domain)
    /// </summary>
    /// <remarks>
    /// Autor: Gonzalo Mata
    /// Fecha: 10/06/2024
    /// </remarks>
    public interface IUsuarioCommand
    {
        /// <summary>
        /// Interfaz Execute que va estar relacionado a su implementación correspondiente
        /// </summary>
        /// <param name="usuarioModel"></param>
        /// <returns>Retorna el objeto de UsuarioModel</returns>
        /// Autor: Gonzalo Mata
        /// Fecha: 10/06/2024
        /// </remarks>
        Task<UsuarioModel> Execute(UsuarioModel usuarioModel);
    }
}

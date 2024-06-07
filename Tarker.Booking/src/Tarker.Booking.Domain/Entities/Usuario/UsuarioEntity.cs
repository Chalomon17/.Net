using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Domain.Entities.Usuario
{
    #region UsuarioEntity
    public class UsuarioEntity
    {
        // Id del Usuario
        public int IdUsuario { get; set; }
        // Nombre del Usuario
        public string Nombre { get; set; }
        // Apellido paterno del Usuario
        public string ApellidoPaterno { get; set; }
        // Apellido materno del Usuario
        public string ApellidoMaterno { get; set; }
        // Password del UsuarioW
        public string Password { get; set; }
    }
    #endregion
}

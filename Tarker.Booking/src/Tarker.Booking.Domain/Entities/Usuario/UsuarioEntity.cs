using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Domain.Entities.Libro;

namespace Tarker.Booking.Domain.Entities.Usuario
{
    #region UsuarioEntity
    public class UsuarioEntity
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
        /// <summary>
        /// Lista de Libros haciendo referencia a la Entidad Libro (Cliente puede tener muchos Libros)
        /// </summary>
        public ICollection<LibroEntity> Libros { get; set; }
    }
    #endregion
}

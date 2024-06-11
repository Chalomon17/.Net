using Tarker.Booking.Domain.Entities.Cliente;
using Tarker.Booking.Domain.Entities.Usuario;

namespace Tarker.Booking.Domain.Entities.Libro
{
    #region LibroEntity

    /// <summary>
    /// Entidad Libro
    /// </summary>
    /// <remarks>
    /// Autor: Gonzalo Mata
    /// Fecha: 10/06/2024
    /// </remarks>
    public class LibroEntity
    {
        /// <summary>
        /// Id del Libro
        /// </summary>
        public int IdLibro { get; set; }
        /// <summary>
        /// Dia del registro del Libro
        /// </summary>
        public DateTime DiaRegistro { get; set; }
        /// <summary>
        /// Código de reserva del Libro
        /// </summary>
        public string Codigo { get; set; }
        /// <summary>
        /// Tipo reserva del Libro
        /// </summary>
        public int Tipo { get; set; }
        /// <summary>
        /// Id Cliente llave foránea de la entidad Cliente
        /// </summary>
        public int IdCliente { get; set; } 
        /// <summary>
        /// Id Usuario llave foránea de la entidad Usuario
        /// </summary>
        public int IdUsuario { get; set; }
        /// <summary>
        /// Referencia a la Entidad Usuario
        /// </summary>
        public UsuarioEntity Usuario { get; set; }
        /// <summary>
        /// Referencia a la Entidad Cliente
        /// </summary>
        public ClienteEntity Cliente { get; set; }
    }
    #endregion
}

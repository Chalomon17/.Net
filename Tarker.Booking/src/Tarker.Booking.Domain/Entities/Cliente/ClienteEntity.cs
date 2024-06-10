using Tarker.Booking.Domain.Entities.Libro;

namespace Tarker.Booking.Domain.Entities.Cliente
{
    #region ClienteEntity
    public class ClienteEntity
    {
        /// <summary>
        /// Id del Cliente
        /// </summary>
        public int IdCliente { get; set; }
        /// <summary>
        /// Nombre completo del Cliente
        /// </summary>
        public string NombreCompleto { get; set; }
        /// <summary>
        /// Número de documento del Cliente
        /// </summary>
        public string NumeroDocumento { get; set; }
        /// <summary>
        /// Lista de Libros haciendo referencia a la Entidad Libro (Cliente puede tener muchos Libros)
        /// </summary>
        public ICollection<LibroEntity> Libros { get; set; }

    }
    #endregion
}

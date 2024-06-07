using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Domain.Entities.Libro
{
    #region LibroEntity
    public class LibroEntity
    {
        // Id del Libro
        public int IdLibro { get; set; }
        // Dia del registro del Libro
        public DateTime DiaRegistro { get; set; }
        // Código de reserva del Libro
        public string Codigo { get; set; }
        // Tipo reserva del Libro
        public int Tipo { get; set; }
        // Id Cliente llave foránea de la entidad Cliente
        public int IdCliente { get; set; } 
        // Id Usuario llave foránea de la entidad Usuario
        public int IdUsuario { get; set; }
    }
    #endregion
}

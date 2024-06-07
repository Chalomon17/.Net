using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.Domain.Entities.Cliente
{
    #region ClienteEntity
    public class ClienteEntity
    {
        // Id del Cliente
        public int IdCliente { get; set; }
        // Nombre completo del Cliente
        public string NombreCompleto { get; set; }
        // Número de documento del Cliente
        public string NumeroDocumento { get; set; }

    }
    #endregion
}

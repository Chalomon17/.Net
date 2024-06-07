using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Domain.Entities.Cliente;

namespace Tarker.Booking.Persistence.Configuracion
{
    public class ClienteConfiguracion
    {
        /// <summary>
        /// Configuración de la entidad Cliente
        /// </summary>
        /// <param name="entityBuilder"></param>
        public ClienteConfiguracion(EntityTypeBuilder<ClienteEntity> entityBuilder) {

            entityBuilder.HasKey(x => x.IdCliente);
            entityBuilder.Property(x => x.NombreCompleto).IsRequired();
            entityBuilder.Property(x => x.NumeroDocumento).IsRequired();

            entityBuilder.HasMany(x => x.Libros)
                .WithOne(x => x.Cliente)
                .HasForeignKey(x => x.IdCliente);
        }
    }
}

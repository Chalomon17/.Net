using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarker.Booking.Domain.Entities.Libro;

namespace Tarker.Booking.Persistence.Configuracion
{
    public class LibroConfiguracion
    {
        /// <summary>
        /// Configuración de la Entidad Libro
        /// </summary>
        /// <param name="entityBuilder"></param>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 07/06/2024
        /// </remarks>
        public LibroConfiguracion(EntityTypeBuilder<LibroEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdLibro);
            entityBuilder.Property(x => x.DiaRegistro).IsRequired();
            entityBuilder.Property(x => x.Codigo).IsRequired();
            entityBuilder.Property(x => x.Tipo).IsRequired();
            entityBuilder.Property(x => x.IdUsuario).IsRequired();
            entityBuilder.Property(x => x.IdCliente).IsRequired();

            entityBuilder.HasOne(x => x.Usuario)
                .WithMany(x => x.Libros)
                .HasForeignKey(x => x.IdUsuario);

            entityBuilder.HasOne(x => x.Cliente)
                .WithMany(x => x.Libros)
                .HasForeignKey(x => x.IdCliente);
        }

    }
}

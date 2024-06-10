using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarker.Booking.Domain.Entities.Usuario;

namespace Tarker.Booking.Persistence.Configuracion
{
    public class UsuarioConfiguracion
    {
        /// <summary>
        /// Confuguración de la Entidad Usuario
        /// </summary>
        /// <param name="entityBuilder"></param>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 07/06/2024
        /// </remarks>
        public UsuarioConfiguracion(EntityTypeBuilder<UsuarioEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdUsuario);
            entityBuilder.Property(x => x.Nombre).IsRequired();
            entityBuilder.Property(x => x.ApellidoPaterno).IsRequired();
            entityBuilder.Property(x => x.ApellidoMaterno).IsRequired();
            entityBuilder.Property(x => x.Password).IsRequired();

            entityBuilder.HasMany(x => x.Libros)
                .WithOne(x => x.Usuario)
                .HasForeignKey(x => x.IdUsuario);
        }
    }
}

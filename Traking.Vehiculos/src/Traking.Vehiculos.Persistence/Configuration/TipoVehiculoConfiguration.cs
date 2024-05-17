using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Traking.Vehiculos.Domain.Entities.TipoVehiculo;

namespace Traking.Vehiculos.Persistence.Configuration
{
    public class TipoVehiculoConfiguration
    {
        public TipoVehiculoConfiguration(EntityTypeBuilder<TipoVehiculoEntity> entityBuilder)
        {
        }
    }
}

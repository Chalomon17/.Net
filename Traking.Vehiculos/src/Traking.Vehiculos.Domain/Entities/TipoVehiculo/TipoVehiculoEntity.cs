using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traking.Vehiculos.Domain.Entities.TipoVehiculo
{
    #region Entidad TipoVehiculo

    public class TipoVehiculoEntity
    {
        // Id del tipo de vehículo
        public Guid IdTipoVehiculo { get; set; }

        // clave del tipo de vehículo
        public string ClaveTipoVehiculo { get; set; }

        // descripción del vehículo
        public string Descripcion { get; set; }

        // Fecha de cuando se creó el registro (Campo de auditoria)
        public DateTime FechaRegistro { get; set; }

        // Fecha de cuando se actualizó el registro (Campo de auditoria)
        public DateTime? FechaActualizacion { get; set; }

        // Usuario quien modificó el registro (Campo de auditoria)
        public string UsuarioModificacion { get; set; }

    }

    #endregion
}

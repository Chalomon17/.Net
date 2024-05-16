using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traking.Vehiculos.Domain.Entities.RastreoVehiculo
{
    #region Entidad RastreoVehiculo

    public class RastreoVehiculoEntity
    {
        // Id del rastreo del vehículo
        public Guid IdRastreoVehiculo { get; set; }

        // Latitud de donde se encuentra el vehículo
        public decimal Latitud { get; set; }

        // Longitud de donde se encuentra el vehículo
        public decimal Longitud { get; set; }

        // Id foranea de Vehículo
        public Guid IdVehiculo { get; set; }

        // Id foranea de Propietarios
        public Guid IdPropietario { get; set; }

        // Fecha de cuando se creó el registro (Campo de auditoria)
        public DateTime FechaRegistro { get; set; }

        // Fecha de cuando se actualizó el registro (Campo de auditoria)
        public DateTime? FechaActualizacion { get; set; }

        // Usuario quien modificó el registro (Campo de auditoria)
        public string UsuarioModificacion { get; set; }
    }

    #endregion
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traking.Vehiculos.Domain.Entities.Vehiculo
{
    #region Entidad Vehiculo

    public class VehiculoEntity
    {
        // Id del vehículo
        public Guid IdVehiculo { get; set; }
   
        // Marca del vehículo
        public string Marca { get; set; }
        
        // SubMarca del vehículo
        public string SubMarca { get; set; }
        
        // Modelo del vehículo
        public int Modelo { get; set; }
        
        // Id foranea del tipo del vehículo
        public Guid IdTipoVehiculo { get; set; }

        // Fecha de cuando se creó el registro (Campo de auditoria)
        public DateTime FechaRegistro { get; set; }

        // Fecha de cuando se actualizó el registro (Campo de auditoria)
        public DateTime? FechaActualizacion { get; set; }

        // Usuario quien modificó el registro (Campo de auditoria)
        public string UsuarioModificacion { get; set; }

    }

    #endregion
}

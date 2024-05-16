using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traking.Vehiculos.Domain.Entities.Propietario
{
    #region Entidad Propietario

    public class PropietarioEntity
    {
        // Id del propietario
        public Guid IdPropietario { get; set; }

        // Nombres del propietario
        public string Nombres { get; set; }

        // Apellido paterno del propietario
        public string ApellidoPaterno { get; set; }

        // Apellido materno del propietario
        public string ApellidoMaterno { get; set; }

        // Dirección del propietario
        public string Direccion { get; set; }

        // Teléfono del propietario
        public int Telefono { get; set; }

        // Fecha de cuando se creó el registro (Campo de auditoria)
        public DateTime FechaRegistro { get; set; }

        // Fecha de cuando se actualizó el registro (Campo de auditoria)
        public DateTime? FechaActualizacion { get; set; }

        // Usuario quien modificó el registro (Campo de auditoria)
        public string UsuarioModificacion { get; set; }
    }

    #endregion
}

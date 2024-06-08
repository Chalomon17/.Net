using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Domain.Entities.Cliente;
using Tarker.Booking.Domain.Entities.Libro;
using Tarker.Booking.Domain.Entities.Usuario;

namespace Tarker.Booking.Application.Interfaces
{
    /// <summary>
    /// Interfaz para los métodos que ofrece DataBaseService.
    /// Son accesos indirectos hacia la base datos pero lo hace a través
    /// de Application.
    /// </summary>
    /// <remarks>
    /// Autor: Gonzalo Mata
    /// Fecha: 07/06/2024
    /// </remarks>
    public interface IDataBaseService
    {
        /// <summary>
        /// Método Usuario relacionado a DataBaseService
        /// </summary>
        DbSet<UsuarioEntity> Usuarios { get; set; }
        /// <summary>
        /// Método Cliente relacionado a DataBaseService
        /// </summary>
        DbSet<ClienteEntity> Cliente { get; set; }
        /// <summary>
        /// Método Libro relacionado a DataBaseService
        /// </summary>
        DbSet<LibroEntity> Libro { get; set; }
        /// <summary>
        /// Método para guardar asincronicamente relacionado a DataBaseService
        /// </summary>
        Task<bool> SaveAsync();
    }
}

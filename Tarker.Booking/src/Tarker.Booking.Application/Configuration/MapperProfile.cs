using AutoMapper;
using Tarker.Booking.Application.DataBase.Usuario.Commands;
using Tarker.Booking.Domain.Entities.Usuario;

namespace Tarker.Booking.Application.Configuration
{
    /// <summary>
    /// Clase de configuración para Profile con AutoMapper.
    /// </summary>
    /// <remarks>
    /// Autor: Gonzalo Mata
    /// Fecha: 10/06/2024
    /// </remarks>
    public class MapperProfile : Profile
    {
        /// <summary>
        /// Constructor para mapaer los objetos que se vayan necesitando.
        /// </summary>
        /// <remarks>
        /// Autor: Gonzalo Mata
        /// Fecha: 10/06/2024
        /// </remarks>
        public MapperProfile() {
            // 1. CreateMap<UsuarioEntity, UsuarioModel>(): Este método define un mapeo entre dos tipos (Entity, Model).
            // 2. ReverseMap(): Este método indica que el mapeo debe ser bidireccional. Es decir,
            // no solo se puede mapear de Entidad a Model, si no también de Model a Entidad.
            CreateMap<UsuarioEntity, UsuarioModel>().ReverseMap();
        
        }
    }
}

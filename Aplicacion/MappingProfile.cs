using Api.Microeservice.Autor.Modelo;
using AutoMapper;

namespace Api.Microeservice.Autor.Aplicacion
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AutorLibro, AutorDto>();
        }
    }
}

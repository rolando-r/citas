using AutoMapper;
using API.Dtos;
using Core.Entities;
namespace API.Profiles;

public class MappingProfiles : Profile
{

    public MappingProfiles(){
        CreateMap<Acudiente,AcudienteDto>().ReverseMap();
        CreateMap<Consultorio,ConsultorioDto>().ReverseMap()
        .ForMember(dest => dest.ConsCodigo, opt => opt.MapFrom(src => src.ConsCodigo))
        .ReverseMap();
    }
}
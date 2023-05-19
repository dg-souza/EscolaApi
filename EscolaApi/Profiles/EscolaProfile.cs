using AutoMapper;
using EscolaApi.Data.Dtos.Escola;
using EscolaApi.Models;

namespace EscolaApi.Profiles;

public class EscolaProfile : Profile
{
    public EscolaProfile()
    {
        CreateMap<CreateEscolaDto, Escola>();
        CreateMap<UpdateEscolaDto, Escola>();
        CreateMap<Escola, ReadEscolaDto>()
            .ForMember(dto => dto.EnderecoDto, opt => opt.MapFrom(escola => escola.Endereco));
    }
}

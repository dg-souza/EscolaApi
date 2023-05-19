using AutoMapper;
using EscolaApi.Data.Dtos.Aluno;
using EscolaApi.Models;

namespace EscolaApi.Profiles;

public class AlunoProfile : Profile
{
    public AlunoProfile()
    {
        CreateMap<CreateAlunoDto, Aluno>();
        CreateMap<UpdateAlunoDto, Aluno>();
        CreateMap<Aluno, ReadAlunoDto>()
            .ForMember(dto => dto.EscolaDto, opt => opt.MapFrom(aluno => aluno.Escola));
    }
}

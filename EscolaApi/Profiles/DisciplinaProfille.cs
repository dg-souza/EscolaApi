using AutoMapper;
using EscolaApi.Data.Dtos.Disciplina;
using EscolaApi.Models;

namespace EscolaApi.Profiles;

public class DisciplinaProfille : Profile
{
    public DisciplinaProfille()
    {
        CreateMap<CreateDisciplinaDto, Disciplina>();
        CreateMap<UpdateDisciplinaDto, Disciplina>();
        CreateMap<Disciplina, CreateDisciplinaDto>();
    }
}

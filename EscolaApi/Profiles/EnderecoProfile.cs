using AutoMapper;
using EscolaApi.Data.Dtos.Endereco;
using EscolaApi.Models;

namespace EscolaApi.Profiles;

public class EnderecoProfile : Profile
{
    public EnderecoProfile()
    {
        CreateMap<CreateEnderecoDto, Endereco>();
        CreateMap<UpdateEnderecoDto, Endereco>();
        CreateMap<Endereco, ReadEnderecoDto>();
    }
}

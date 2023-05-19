using EscolaApi.Data.Dtos.Endereco;
using EscolaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EscolaApi.Services.Interfaces;

public interface IEnderecoService
{
    public Task<Endereco> create([FromBody] CreateEnderecoDto dto);

    public Task<IEnumerable<ReadEnderecoDto>> getAll();

    public Task<ReadEnderecoDto> getById(int id);
}

using EscolaApi.Data.Dtos.Aluno;
using EscolaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EscolaApi.Services;

public class AlunoService : IAlunoService
{
    public Task<IActionResult> create([FromBody] CreateAlunoDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ReadAlunoDto>> getAll()
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> getById(int id)
    {
        throw new NotImplementedException();
    }
}

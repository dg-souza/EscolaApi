using EscolaApi.Data.Dtos.Aluno;
using Microsoft.AspNetCore.Mvc;

namespace EscolaApi.Services.Interfaces;

public interface IAlunoService
{
    public Task<IActionResult> create([FromBody] CreateAlunoDto dto);

    public Task<IEnumerable<ReadAlunoDto>> getAll();

    public Task<IActionResult> getById(int id);
}

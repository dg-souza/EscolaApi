using EscolaApi.Data.Dtos.Aluno;
using Microsoft.AspNetCore.Mvc;

namespace EscolaApi.Services.Interfaces;

public interface IAlunoService
{
    public Task create([FromBody] CreateAlunoDto dto);

    public Task<IEnumerable<ReadAlunoDto>> getAll();

    public Task<ReadAlunoDto> getById(int id);

    public Task update(int id, [FromBody] UpdateAlunoDto dto);
}

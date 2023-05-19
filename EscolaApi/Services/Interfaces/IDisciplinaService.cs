using EscolaApi.Data.Dtos.Aluno;
using EscolaApi.Data.Dtos.Disciplina;
using Microsoft.AspNetCore.Mvc;

namespace EscolaApi.Services.Interfaces;

public interface IDisciplinaService
{
    public Task create([FromBody] CreateDisciplinaDto dto);

    public Task<IEnumerable<ReadDisciplinaDto>> getAll();

    public Task<ReadDisciplinaDto> getById(int id);

    public Task update(int id, [FromBody] UpdateDisciplinaDto dto);
}

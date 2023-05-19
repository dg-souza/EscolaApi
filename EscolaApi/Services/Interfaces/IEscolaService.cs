using EscolaApi.Data.Dtos.Escola;
using Microsoft.AspNetCore.Mvc;

namespace EscolaApi.Services.Interfaces;

public interface IEscolaService
{
    public Task create([FromBody] CreateEscolaDto dto);

    public Task<IEnumerable<ReadEscolaDto>> getAll();

    public Task<ReadEscolaDto> getById(int id);

    public Task update(int id, UpdateEscolaDto dto);
}

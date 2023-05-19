using EscolaApi.Data.Dtos.Disciplina;
using EscolaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DisciplinaApi.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("[controller]")]
public class DisciplinaController : ControllerBase
{
    private readonly IDisciplinaService _service;

    public DisciplinaController(IDisciplinaService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> create([FromBody] CreateDisciplinaDto dto)
    {
        await _service.create(dto);

        return NoContent();
    }

    [HttpGet]
    public async Task<IEnumerable<ReadDisciplinaDto>> getAll()
    {
        var res = await _service.getAll();

        return res;
    }

    [HttpGet("{id}")]
    public async Task<ReadDisciplinaDto> getById(int id)
    {
        var res = await _service.getById(id);

        return res;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> update(int id, [FromBody] UpdateDisciplinaDto dto)
    {
        await _service.update(id, dto);

        return NoContent();
    }
}

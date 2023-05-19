using EscolaApi.Data.Dtos.Escola;
using EscolaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EscolaApi.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("[controller]")]
public class EscolaController : ControllerBase
{
    private readonly IEscolaService _service;

    public EscolaController(IEscolaService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> create([FromBody] CreateEscolaDto dto)
    {
        await _service.create(dto);

        return NoContent();
    }

    [HttpGet]
    public async Task<IEnumerable<ReadEscolaDto>> getAll()
    {
        var res = await _service.getAll();

        return res;
    }

    [HttpGet("{id}")]
    public async Task<ReadEscolaDto> getById(int id)
    {
        var res = await _service.getById(id);

        return res;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> update(int id, [FromBody] UpdateEscolaDto dto)
    {
        await _service.update(id, dto);

        return NoContent();
    }
}

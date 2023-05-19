using EscolaApi.Data.Dtos.Endereco;
using EscolaApi.Services;
using EscolaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EscolaApi.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("[controller]")]
public class EnderecoController : ControllerBase
{
    private readonly IEnderecoService _enderecoService;

    public EnderecoController(IEnderecoService enderecoService)
    {
        _enderecoService = enderecoService;
    }

    [HttpPost]
    public async Task<IActionResult> create([FromBody] CreateEnderecoDto dto)
    {
        var res = await _enderecoService.create(dto);

        return Ok(res);
    }

    [HttpGet]
    public async Task<IEnumerable<ReadEnderecoDto>> getAll()
    {
        var res = await _enderecoService.getAll();

        return res;
    }

    [HttpGet("{id}")]
    public async Task<ReadEnderecoDto> getById(int id)
    {
        var res = await _enderecoService.getById(id);

        return res;
    }
}

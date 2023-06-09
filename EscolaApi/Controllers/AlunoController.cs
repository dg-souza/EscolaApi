﻿using EscolaApi.Data.Dtos.Aluno;
using EscolaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AlunoApi.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("[controller]")]
public class AlunoController : ControllerBase
{
    private readonly IAlunoService _service;

    public AlunoController(IAlunoService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> create([FromBody] CreateAlunoDto dto)
    {
        await _service.create(dto);

        return NoContent();
    }

    [HttpGet]
    public async Task<IEnumerable<ReadAlunoDto>> getAll()
    {
        var res = await _service.getAll();

        return res;
    }

    [HttpGet("{id}")]
    public async Task<ReadAlunoDto> getById(int id)
    {
        var res = await _service.getById(id);

        return res;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> update(int id, [FromBody] UpdateAlunoDto dto)
    {
        await _service.update(id, dto);

        return NoContent();
    }
}

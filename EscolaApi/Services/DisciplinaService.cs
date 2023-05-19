using AutoMapper;
using EscolaApi.Data;
using EscolaApi.Data.Dtos.Disciplina;
using EscolaApi.Models;
using EscolaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DisciplinaApi.Services;

public class DisciplinaService : IDisciplinaService
{
    private readonly EscolaContext _context;
    private readonly IMapper _mapper;

    public DisciplinaService(EscolaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task create([FromBody] CreateDisciplinaDto dto)
    {
        Disciplina Disciplina = _mapper.Map<Disciplina>(dto);

        await _context.Disciplinas.AddAsync(Disciplina);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<ReadDisciplinaDto>> getAll()
    {
        var res = await _context.Disciplinas.ToListAsync();

        if (res == null) throw new ApplicationException("Erro ao buscar Disciplinas");

        return _mapper.Map<List<ReadDisciplinaDto>>(res);
    }

    public async Task<ReadDisciplinaDto> getById(int id)
    {
        var res = await _context.Disciplinas.FirstOrDefaultAsync(x => x.Id == id);

        if (res == null) throw new ApplicationException("Disciplina não encontrada");

        return _mapper.Map<ReadDisciplinaDto>(res);
    }

    public async Task update(int id, [FromBody] UpdateDisciplinaDto dto)
    {
        var res = await _context.Disciplinas.FirstOrDefaultAsync(x => x.Id == id);

        if (res == null) throw new ApplicationException("Erro ao buscar Disciplinas");

        _mapper.Map(dto, res);

        await _context.SaveChangesAsync();
    }
}

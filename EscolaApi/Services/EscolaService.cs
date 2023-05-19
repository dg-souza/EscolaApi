using AutoMapper;
using EscolaApi.Data;
using EscolaApi.Data.Dtos.Escola;
using EscolaApi.Models;
using EscolaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EscolaApi.Services;

public class EscolaService : IEscolaService
{
    private readonly EscolaContext _context;
    private readonly IMapper _mapper;

    public EscolaService(EscolaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task create([FromBody] CreateEscolaDto dto)
    {
        Escola escola = _mapper.Map<Escola>(dto);

        await _context.Escolas.AddAsync(escola);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<ReadEscolaDto>> getAll()
    {
        var res = await _context.Escolas.ToListAsync();

        if (res == null) throw new ApplicationException("Erro ao buscar escolas");

        return _mapper.Map<List<ReadEscolaDto>>(res);
    }

    public async Task<ReadEscolaDto> getById(int id)
    {
        var res = await _context.Escolas.FirstOrDefaultAsync(x => x.Id == id);

        if (res == null) throw new ApplicationException("Escola não encontrada");

        return _mapper.Map<ReadEscolaDto>(res);
    }

    public async Task update(int id, [FromBody] UpdateEscolaDto dto)
    {
        var res = await _context.Escolas.FirstOrDefaultAsync(x => x.Id == id);

        if (res == null) throw new ApplicationException("Erro ao buscar escolas");

        _mapper.Map(dto, res);

        await _context.SaveChangesAsync();
    }
}

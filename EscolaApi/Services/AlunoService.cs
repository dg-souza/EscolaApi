using AutoMapper;
using EscolaApi.Data;
using EscolaApi.Data.Dtos.Aluno;
using EscolaApi.Data.Dtos.Aluno;
using EscolaApi.Models;
using EscolaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlunoApi.Services;

public class AlunoService : IAlunoService
{
    private readonly EscolaContext _context;
    private readonly IMapper _mapper;

    public AlunoService(EscolaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task create([FromBody] CreateAlunoDto dto)
    {
        Aluno Aluno = _mapper.Map<Aluno>(dto);

        await _context.Alunos.AddAsync(Aluno);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<ReadAlunoDto>> getAll()
    {
        var res = await _context.Alunos.ToListAsync();

        if (res == null) throw new ApplicationException("Erro ao buscar Alunos");

        return _mapper.Map<List<ReadAlunoDto>>(res);
    }

    public async Task<ReadAlunoDto> getById(int id)
    {
        var res = await _context.Alunos.FirstOrDefaultAsync(x => x.Id == id);

        if (res == null) throw new ApplicationException("Aluno não encontrada");

        return _mapper.Map<ReadAlunoDto>(res);
    }

    public async Task update(int id, [FromBody] UpdateAlunoDto dto)
    {
        var res = await _context.Alunos.FirstOrDefaultAsync(x => x.Id == id);

        if (res == null) throw new ApplicationException("Erro ao buscar Alunos");

        _mapper.Map(dto, res);

        await _context.SaveChangesAsync();
    }
}

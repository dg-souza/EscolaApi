using AutoMapper;
using EscolaApi.Data;
using EscolaApi.Data.Dtos.Endereco;
using EscolaApi.Models;
using EscolaApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EscolaApi.Services;

public class EnderecoService : IEnderecoService
{
    private EscolaContext _context;
    private IMapper _mapper;

    public EnderecoService(EscolaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Endereco> create([FromBody] CreateEnderecoDto dto)
    {
        try
        {
            Endereco endereco = _mapper.Map<Endereco>(dto);

            await _context.Enderecos.AddAsync(endereco);

            await _context.SaveChangesAsync();

            return endereco;
        } catch(Exception ex)
        {
            throw new ApplicationException("Falha ao criar endereço, Erro: " + ex.Message);
        }
    }

    public async Task<IEnumerable<ReadEnderecoDto>> getAll()
    {
        var res = await _context.Enderecos.ToListAsync();

        if (res == null) throw new ApplicationException("Não foi encontrado");

        return _mapper.Map<List<ReadEnderecoDto>>(res);
    }

    public async Task<ReadEnderecoDto> getById(int id)
    {
        var res = await _context.Enderecos.FirstOrDefaultAsync(x => x.Id == id);

        if (res == null) throw new ApplicationException("Endereço não encontrado");

        return _mapper.Map<ReadEnderecoDto>(res);
    }
}

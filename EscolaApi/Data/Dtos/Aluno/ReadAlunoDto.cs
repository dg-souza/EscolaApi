using EscolaApi.Data.Dtos.Escola;

namespace EscolaApi.Data.Dtos.Aluno;

public class ReadAlunoDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int EscolaId { get; set; }

    public ReadEscolaDto EscolaDto { get; set; }
}

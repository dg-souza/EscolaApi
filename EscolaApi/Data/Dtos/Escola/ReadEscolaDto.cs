using EscolaApi.Data.Dtos.Endereco;

namespace EscolaApi.Data.Dtos.Escola;

public class ReadEscolaDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int EnderecoId { get; set; }

    public ReadEnderecoDto EnderecoDto { get; set; }
}

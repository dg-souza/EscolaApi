using System.ComponentModel.DataAnnotations;

namespace EscolaApi.Models;

public class Escola
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int EnderecoId { get; set; }

    public virtual Endereco Endereco { get; set; }

    public virtual Aluno Aluno { get; set; }
}

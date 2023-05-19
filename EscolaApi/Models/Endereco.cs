using System.ComponentModel.DataAnnotations;

namespace EscolaApi.Models;

public class Endereco
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Logradouro { get; set; }

    [Required]
    public string Numero { get; set; }

    [Required]
    public string Cep { get; set; }

    [Required]
    public string Bairro { get; set; }

    public virtual Escola Escola { get; set; }
}

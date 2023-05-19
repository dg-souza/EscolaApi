using System.ComponentModel.DataAnnotations;

namespace EscolaApi.Models;

public class Aluno
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public int Name { get; set; }

    public int EscolaId { get; set; }

    public virtual Escola Escola { get; set; }

    public virtual GradeCurricular GradeCurricular { get; set; }
}

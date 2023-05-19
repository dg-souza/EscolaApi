namespace EscolaApi.Models;

public class GradeCurricular
{
    public int Id { get; set; }

    public int AlunoId { get; set; }

    public virtual Aluno Aluno { get; set; }

    public int DisciplinaId { get; set; }

    public virtual ICollection<Disciplina> Disciplina { get; set; }
}

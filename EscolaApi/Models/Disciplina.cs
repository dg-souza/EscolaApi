namespace EscolaApi.Models;

public class Disciplina
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual GradeCurricular GradeCurricular { get; set; }
}

using EscolaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaApi.Data;

public class EscolaContext : DbContext
{
    public EscolaContext(DbContextOptions<EscolaContext> opts) : base(opts) {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Endereco>()
            .HasOne(endereco => endereco.Escola)
            .WithOne(escola => escola.Endereco)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Aluno>()
            .HasOne(aluno => aluno.Escola)
            .WithOne(escola => escola.Aluno);

        builder.Entity<GradeCurricular>()
            .HasOne(grade => grade.Aluno)
            .WithOne(aluno => aluno.GradeCurricular);

        builder.Entity<GradeCurricular>()
            .HasMany(grade => grade.Disciplina)
            .WithOne(disc => disc.GradeCurricular);
    }

    public DbSet<Aluno> Alunos { get; set; }

    public DbSet<Endereco> Enderecos { get; set; }

    public DbSet<Escola> Escolas { get; set; }

    public DbSet<Disciplina> Disciplinas { get; set;}

    public DbSet<GradeCurricular> GradeCurricular { get; set; }
}

using Microsoft.EntityFrameworkCore;
using SistemaMatricula.mvc.Models;

namespace SistemaMatricula.mvc.Database
{
    public class MatriculaContext : DbContext
    {
        public MatriculaContext(DbContextOptions<MatriculaContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Matriculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var matricula = modelBuilder.Entity<Aluno>();

            //Nome Tabela
            matricula.ToTable("TB_MATRICULAS");

            //Index
            matricula.HasIndex(x => x.MatriculaId).HasDatabaseName("IX_MATRICULA_UNIQUE");
            matricula.HasIndex(x => x.Nome).HasDatabaseName("IX_NOME_UNIQUE");

            //PK
            matricula.HasKey(x => x.MatriculaId);

            //Colunas
            matricula.Property(x => x.Nome).HasColumnName("NOME_ALUNO").HasMaxLength(50).HasDefaultValue("CAMPO-VAZIO").IsRequired();
            matricula.Property(x => x.Curso).HasColumnName("NOME_CURSO").HasMaxLength(100).HasDefaultValue("CAMPO-VAZIO").IsRequired();
            matricula.Property(x => x.Unidade).HasColumnName("UNIDADE").HasMaxLength(20).HasDefaultValue("CAMPO-VAZIO").IsRequired();
            matricula.Property(x => x.DataMatricula).HasColumnName("DATA_MATRICULA").HasDefaultValue(DateTime.Now);

            #region SEEDS
            matricula.HasData
                (
                    new Aluno { MatriculaId = 1, Nome = "Erik Fernandes", Curso = "Análise e Desenvolvimento de Sistemas", Unidade = "Vergueiro" },
                    new Aluno { MatriculaId = 2, Nome = "Marcos Felipe", Curso = "Enfermagem", Unidade = "São Judas" },
                    new Aluno { MatriculaId = 3, Nome = "Mariana Dias", Curso = "Odontólogia", Unidade = "Vila Mariana" },
                    new Aluno { MatriculaId = 4, Nome = "Leticia Silva", Curso = "Publicidade e Propaganda", Unidade = "Paulista" },
                    new Aluno { MatriculaId = 5, Nome = "Beatriz Reis", Curso = "Culínaria", Unidade = "Praça da Arvoré" },
                    new Aluno { MatriculaId = 6, Nome = "Vinicius Muller", Curso = "Administração", Unidade = "Saúde" }
                );
            #endregion
        }

    }
}

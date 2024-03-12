using AppWebCadastroAluno.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWebCadastroAluno.DAL
{
    public class INFNETContexto : DbContext
    {
        public INFNETContexto(DbContextOptions options) : base (options)
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //aqui que vamos definir o relacionamento entre as classes
            modelBuilder.Entity<Aluno>()
                        .HasOne(a => a.Endereco) //aqui estou indicando que um aluno tem um relacionamento com um endereço
                        .WithOne(e => e.Aluno) // indicando que um endreço tem um reclaciomento com um alunos
                        .HasForeignKey<Aluno>(a => a.EnderecoId); //aqui estou definindo que achave que vai mapear o relacionamento é o endereco ID

            modelBuilder.Entity<Matricula>()
                        .HasOne(m => m.Aluno)
                        .WithMany(a => a.Matriculas)
                        .HasForeignKey(m => m.AlunoId);

            modelBuilder.Entity<Matricula>()
                        .HasOne(m => m.Curso)
                        .WithMany(c => c.Matriculas)
                        .HasForeignKey(m => m.CursoId);
        }

    }
}

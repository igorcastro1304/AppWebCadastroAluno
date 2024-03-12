using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppWebCadastroAluno.Models
{
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Matricula { get; set; }

        [ForeignKey("Endereco")]
        public int EnderecoId { get; set; }

        public virtual Endereco? Endereco { get; set; }

        public ICollection<Matricula>? Matriculas { get; set; }
    }
}

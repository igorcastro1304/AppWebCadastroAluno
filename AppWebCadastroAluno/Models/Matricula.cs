using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppWebCadastroAluno.Models
{
    public class Matricula
    {
        [Key]
        public int MatriculaId { get; set; }
        [Required]
        public int AnoIngresso { get; set; }
        public int AlunoId {  get; set; }
        public int CursoId { get; set; }

        [ForeignKey("AlunoId")]
        public virtual Aluno? Aluno { get; set; }
        [ForeignKey("CursoId")]
        public virtual Curso? Curso { get; set; }

    }
}

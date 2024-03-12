using System.ComponentModel.DataAnnotations;

namespace AppWebCadastroAluno.Models
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        public int Anos { get; set; }
        [Required]
        public int Horas { get; set; }


        public ICollection<Matricula>? Matriculas { get; set; }


    }
}

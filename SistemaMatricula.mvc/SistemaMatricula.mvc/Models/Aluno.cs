namespace SistemaMatricula.mvc.Models
{
    public class Aluno
    {
        public int MatriculaId { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public string Unidade { get; set; }
        public DateTimeOffset DataMatricula { get; set; } = DateTimeOffset.Now;
    }
}

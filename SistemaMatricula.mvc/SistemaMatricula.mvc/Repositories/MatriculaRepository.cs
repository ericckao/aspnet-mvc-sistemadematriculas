using SistemaMatricula.mvc.Database;
using SistemaMatricula.mvc.Models;

namespace SistemaMatricula.mvc.Repositories
{
    public class MatriculaRepository : IMatriculaRepository
    {
        private readonly MatriculaContext _db;

        //Injeção de depêndencias
        public MatriculaRepository(MatriculaContext db)
        {
            _db = db;
        }

        //GET
        public IEnumerable<Aluno> Get()
        {
            var lista = _db.Matriculas;
            return lista;
        }
    }
}

using SistemaMatricula.mvc.Models;

namespace SistemaMatricula.mvc.Repositories
{
    public interface IMatriculaRepository
    {
        /*
         * CRUD - Creeate, Retrieve, Update e Delete
         */

        IEnumerable<Aluno> Get();


    }
}

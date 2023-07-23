using SistemaMatricula.mvc.Models;

namespace SistemaMatricula.mvc.Repositories
{
    public interface IMatriculaRepository
    {
        /*
         * CRUD - Creeate, Retrieve, Update e Delete
         */

        public IEnumerable<Aluno> Get();
        public void Cadastrar(Aluno aluno);


    }
}

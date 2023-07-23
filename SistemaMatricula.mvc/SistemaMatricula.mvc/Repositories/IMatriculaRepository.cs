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
        public Aluno BuscarPorId(int id);
        public void Atualizar(Aluno aluno); 
        public void Deletar(Aluno aluno);



    }
}

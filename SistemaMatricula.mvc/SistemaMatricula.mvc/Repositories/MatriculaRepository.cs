using Microsoft.AspNetCore.Mvc;
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

        //GET BY ID
        public Aluno BuscarPorId(int id)
        {
           return _db.Matriculas.FirstOrDefault(x => x.MatriculaId == id)!;
        }

        //CREATE
        public void Cadastrar(Aluno aluno)
        {
            _db.Add(aluno);
            _db.SaveChanges();
        }

         //Update
        public void Atualizar(Aluno aluno)
        {
            _db.Remove(BuscarPorId(aluno.MatriculaId));
            _db.Add(aluno);
            _db.SaveChanges();
        }

        //Delete
        public void Deletar(Aluno aluno)
        {
            _db.Remove(aluno);
            _db.SaveChanges();


        }
    }
}

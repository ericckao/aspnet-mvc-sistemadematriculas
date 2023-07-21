using Microsoft.AspNetCore.Mvc;
using SistemaMatricula.mvc.Database;
using SistemaMatricula.mvc.Models;

namespace SistemaMatricula.mvc.Controllers
{
    public class MatriculasController : Controller
    {
        private readonly MatriculaContext _db;

        public MatriculasController(MatriculaContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //Salvando toda a tabela do banco de dados em uma Enumerable e passando esse para a view
            IEnumerable<Aluno> aluno = _db.Matriculas;
            return View(aluno);
        }
    }
}

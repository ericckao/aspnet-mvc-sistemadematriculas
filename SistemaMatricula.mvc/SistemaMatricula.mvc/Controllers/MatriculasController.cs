using Microsoft.AspNetCore.Mvc;
using SistemaMatricula.mvc.Database;
using SistemaMatricula.mvc.Models;
using SistemaMatricula.mvc.Repositories;

namespace SistemaMatricula.mvc.Controllers
{
    public class MatriculasController : Controller
    {
        private readonly IMatriculaRepository _repository;

        public MatriculasController(IMatriculaRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
           var listaMatriculas =_repository.Get();
            return View(listaMatriculas);
        }

    }
}

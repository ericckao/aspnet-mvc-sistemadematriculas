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
            var listaMatriculas = _repository.Get();
            return View(listaMatriculas);
        }

        //GET
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        //CREATE
        [HttpPost]
        public IActionResult Cadastrar(Aluno matricula)
        {
            if (ModelState.IsValid) //Verifica se a model recebida é valida
            {
                _repository.Cadastrar(matricula);

                //Mensagem de sucesso ao cadastrar
                TempData["MensagemSucesso"] = "Matrícula realizada com sucesso!";

                return RedirectToAction("Index"); //Após o cadastro, redirecionando para a index
            }

            return View(); //Caso a model estiver incorreta, ele continuará na pagina de cadastro.
        }

        //GET by ID
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var registro = _repository.BuscarPorId(id);

            if(registro == null || registro.MatriculaId == 0)
            {
                return NotFound();
            }
            //Capturando o registro e jogando pra tela de Editar com os dados do usuário.
            return View(registro);
        }

        //UPDATE
        [HttpPost]
        public IActionResult Editar(Aluno matricula)
        {
            if (ModelState.IsValid) //Verifica se a model recebida é valida
            {
                _repository.Atualizar(matricula);

                TempData["MensagemSucesso"] = "Edição realizada com sucesso!";

                return RedirectToAction("Index"); //Após o cadastro, redirecionando para a index
            }

            return View(); //Caso a model estiver incorreta, ele continuará na pagina de cadastro.
        }

        //DELETE

        //Recuperando o registro que está na tela.
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            var registro = _repository.BuscarPorId(id);

            if (registro == null || registro.MatriculaId == 0)
            {
                return NotFound();
            }
            //Capturando o registro e jogando pra tela de Editar com os dados do usuário.
            return View(registro);
        }

        [HttpPost]
        public IActionResult Excluir(Aluno registro)
        {
            if (registro == null)
            {
                return NotFound();
            }

            _repository.Deletar(registro);

            TempData["MensagemSucesso"] = "Exclusão realizada com sucesso!";

            return RedirectToAction("Index"); //Após o cadastro, redirecionando para a index
        }

    }
}

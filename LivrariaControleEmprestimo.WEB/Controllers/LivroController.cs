using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class LivroController : Controller
    {
        private LivroService livroService = new LivroService();
        public IActionResult Index()
        {
            List<Livro> listLivro = livroService.repositoryLivro.SelecionarTodos();
            return View(listLivro);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Livro model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            livroService.repositoryLivro.Incluir(model);

            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Livro livro = livroService.repositoryLivro.SelecionarPk(id);
            return View(livro);
        }

        public IActionResult Edit(int id)
        {
            Livro livro = livroService.repositoryLivro.SelecionarPk(id);
            return View(livro);
        }

        [HttpPost]
        public IActionResult Edit(Livro model)
        {
            Livro livro = livroService.repositoryLivro.Alterar(model);
            int id = livro.Id;
            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            livroService.repositoryLivro.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}

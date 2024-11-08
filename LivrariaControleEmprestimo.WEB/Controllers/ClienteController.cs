using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService clienteService = new ClienteService();
        public IActionResult Index()
        {
            List<Cliente> listClientes = clienteService.repositoryCliente.SelecionarTodos();
            return View(listClientes);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            clienteService.repositoryCliente.Incluir(model);

            return RedirectToAction("Index");
        }
    }
}

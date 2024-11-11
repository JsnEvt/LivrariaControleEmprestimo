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
        public IActionResult Details(int id)
        {
            Cliente cliente = clienteService.repositoryCliente.SelecionarPk(id);
            return View(cliente);
        }

        public IActionResult Edit(int id)
        {
            Cliente cliente = clienteService.repositoryCliente.SelecionarPk(id);
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente model)
        {
            Cliente cliente = clienteService.repositoryCliente.Alterar(model);
            int id = cliente.Id;
            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            var cliente = clienteService.repositoryCliente.SelecionarPk(id);
            clienteService.repositoryCliente.Excluir(cliente);
            return RedirectToAction("Index");
        }
    }
}
using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using LivrariaControleEmprestimo.WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        private VmEmprestimoNovoService _service = new VmEmprestimoNovoService();
        public IActionResult Index()
        {
           List<VwEmprestimoNovo> listVmEmprestimo = _service.repositoryVmEmprestimoNovo.SelecionarTodos();
            return View(listVmEmprestimo);
        }
        public IActionResult Create()
        {
            EmprestimoViewModel emprestimoViewModel = new EmprestimoViewModel();
            List<Cliente> listCliente = _service.repositoryCliente.SelecionarTodos();
            List<Livro> listLivro = _service.repositoryLivro.SelecionarTodos();

            emprestimoViewModel.listClientes = listCliente;
            emprestimoViewModel.listLivros = listLivro;

            return View(emprestimoViewModel);
        }
    }
}

using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
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
    }
}

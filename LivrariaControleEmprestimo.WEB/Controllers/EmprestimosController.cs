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

            emprestimoViewModel.dataEmprestimo = DateTime.Now;
            emprestimoViewModel.dataEntrega = DateTime.Now.AddDays(15);

            return View(emprestimoViewModel);
        }

        //aqui adicionamos uma view para listar os registro dos livros emprestados
        //apos a selecao dos mesmos.

        [HttpPost]
        public IActionResult Create(EmprestimoViewModel emprestimoVM)
        {

            Emprestimo emprestimo = new Emprestimo();
            emprestimo.DataEmprestimo = emprestimoVM.dataEmprestimo;
            emprestimo.DataEntrega = emprestimoVM.dataEntrega;
            emprestimo.Entregue = false;
            emprestimo.IdCliente = emprestimoVM.idCliente;
            emprestimo.IdLivro = emprestimoVM.idLivro;


            if(ModelState.IsValid) 
                {
                    return View();
                }

                _service.repositoryEmprestimo.Incluir(emprestimo);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            EmprestimoViewModel emprestimoViewModel = new EmprestimoViewModel();

            emprestimoViewModel.listClientes = _service.repositoryCliente.SelecionarTodos();
            emprestimoViewModel.listLivros = _service.repositoryLivro.SelecionarTodos();

            Emprestimo emprestimo = _service.repositoryEmprestimo.SelecionarPk(id);
            emprestimoViewModel.emprestimo = emprestimo;
            return View();
        }
    }
}

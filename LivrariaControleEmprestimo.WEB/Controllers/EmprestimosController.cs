using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using LivrariaControleEmprestimo.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        private readonly VmEmprestimoNovoService _service = new VmEmprestimoNovoService();
        private readonly ILogger<EmprestimosController> _logger;

        public EmprestimosController(ILogger<EmprestimosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                List<VwEmprestimoNovo> listVmEmprestimo = _service.repositoryVmEmprestimoNovo.SelecionarTodos() ?? new List<VwEmprestimoNovo>();
                return View(listVmEmprestimo);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao carregar a lista de empréstimos.");
                return StatusCode(500, "Erro interno no servidor.");
            }
        }

        public IActionResult Create()
        {
            try
            {
                var emprestimoViewModel = new EmprestimoViewModel
                {
                    listClientes = _service.repositoryCliente.SelecionarTodos() ?? new List<Cliente>(),
                    listLivros = _service.repositoryLivro.SelecionarTodos() ?? new List<Livro>(),
                    dataEmprestimo = DateTime.Now,
                    dataEntrega = DateTime.Now.AddDays(15)
                };

                return View(emprestimoViewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao carregar a página de criação de empréstimos.");
                return StatusCode(500, "Erro interno no servidor.");
            }
        }

        [HttpPost]
        public IActionResult Create(EmprestimoViewModel emprestimoVM)
        {
            if (!ModelState.IsValid)
            {
                emprestimoVM.listClientes = _service.repositoryCliente.SelecionarTodos() ?? new List<Cliente>();
                emprestimoVM.listLivros = _service.repositoryLivro.SelecionarTodos() ?? new List<Livro>();

                _logger.LogWarning("Modelo inválido enviado para criação de empréstimo.");
                return View(emprestimoVM);
            }

            try
            {
                var emprestimo = new Emprestimo
                {
                    DataEmprestimo = emprestimoVM.dataEmprestimo,
                    DataEntrega = emprestimoVM.dataEntrega,
                    Entregue = false,
                    IdCliente = emprestimoVM.idCliente,
                    IdLivro = emprestimoVM.idLivro
                };

                _service.repositoryEmprestimo.Incluir(emprestimo);

                _logger.LogInformation("Empréstimo criado com sucesso.");
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar o empréstimo.");
                ModelState.AddModelError(string.Empty, "Erro ao salvar o empréstimo.");
                return View(emprestimoVM);
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                var emprestimo = _service.repositoryEmprestimo.SelecionarPk(id);
                if (emprestimo == null)
                {
                    _logger.LogWarning($"Empréstimo com ID {id} não encontrado.");
                    return NotFound(); // Retorna erro 404 se o empréstimo não existir
                }

                var emprestimoViewModel = new EmprestimoViewModel
                {
                    emprestimo = emprestimo,
                    listClientes = _service.repositoryCliente.SelecionarTodos() ?? new List<Cliente>(),
                    listLivros = _service.repositoryLivro.SelecionarTodos() ?? new List<Livro>()
                };

                return View(emprestimoViewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao carregar a página de edição.");
                return StatusCode(500, "Erro interno no servidor.");
            }
        }

        [HttpPost]
        public IActionResult Edit(EmprestimoViewModel emprestimoViewModel)
        {
            if (!ModelState.IsValid)
            {
                emprestimoViewModel.listClientes = _service.repositoryCliente.SelecionarTodos() ?? new List<Cliente>();
                emprestimoViewModel.listLivros = _service.repositoryLivro.SelecionarTodos() ?? new List<Livro>();

                _logger.LogWarning("Modelo inválido enviado para edição de empréstimo.");
                return View(emprestimoViewModel);
            }

            try
            {
                _service.repositoryEmprestimo.Alterar(emprestimoViewModel.emprestimo);

                _logger.LogInformation($"Empréstimo com ID {emprestimoViewModel.emprestimo.Id} atualizado com sucesso.");
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao salvar alterações do empréstimo.");
                ModelState.AddModelError(string.Empty, "Erro ao salvar alterações.");
                return View(emprestimoViewModel);
            }
        }
    }
}

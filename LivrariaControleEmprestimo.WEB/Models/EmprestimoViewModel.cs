using LivrariaControleEmprestimo.DATA.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace LivrariaControleEmprestimo.WEB.Models
{
    public class EmprestimoViewModel
    {
        public Livro livro {  get; set; }
        public Cliente cliente { get; set; }

        public int idCliente { get; set; }

        public int idLivro { get; set; }

        public DateTime dataEmprestimo { get; set; }
        public DateTime dataEntrega { get; set; }
        //o atributo abaixo ja carrega varios dos atributos acima e poder-se-ia
        //usar apenas este indicado abaixo:
        public Emprestimo emprestimo { get; set; }

        public List<Cliente> listClientes { get; set; }

        public List<Livro> listLivros { get; set; }
    }
}

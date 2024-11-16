using LivrariaControleEmprestimo.DATA.Models;

namespace LivrariaControleEmprestimo.WEB.Models
{
    public class EmprestimoViewModel
    {
        public Livro livro {  get; set; }
        public Cliente cliente { get; set; }
        public DateTime dataEmprestimo { get; set; }
        public DateTime dataEntrega { get; set; }


        public List<Cliente> listClientes { get; set; }
        public List<Livro> listLivros { get; set; }
    }
}

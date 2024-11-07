using LivrariaControleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class ClienteService
    {
        public RepositoryCliente repositoryCliente {  get; set; }

        public ClienteService()
        {
            repositoryCliente = new RepositoryCliente();
        }
    }
}

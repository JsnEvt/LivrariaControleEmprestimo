using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    internal class RepositoryEmprestimo : RepositoryBase<Emprestimo>, IRepositoryEmprestimo
    {
        public RepositoryEmprestimo(bool SaveChanges = true) : base(SaveChanges) { };
    }
}

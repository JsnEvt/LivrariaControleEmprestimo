using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryVwEmprestimoNovo: RepositoryBase<VwEmprestimoNovo>, IRepositoryVwEmprestimoNovo
    {
        public RepositoryVwEmprestimoNovo(bool SaveChanges = true): base(SaveChanges) { }
    }
}

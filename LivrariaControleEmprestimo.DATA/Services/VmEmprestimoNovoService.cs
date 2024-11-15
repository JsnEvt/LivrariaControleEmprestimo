﻿using LivrariaControleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class VmEmprestimoNovoService
    {
        public RepositoryVwEmprestimoNovo repositoryVmEmprestimoNovo {  get; set; }
        public VmEmprestimoNovoService() 
        {
            repositoryVmEmprestimoNovo = new RepositoryVwEmprestimoNovo();
        }
    }
}
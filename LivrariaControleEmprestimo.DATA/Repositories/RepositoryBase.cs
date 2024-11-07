using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected ControleEmprestimoLivroContext _contexto;
        public bool _SaveChanges = true;

        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _contexto = new ControleEmprestimoLivroContext();
        }
        public T Alterar(T objeto)
        {
            _contexto.Entry(objeto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }
            return objeto;
        }

        public void Dispose()
        {
            _contexto?.Dispose();
        }

        public void Excliur(params object[] variavel)
        {
            var obj = SelecionarPk(variavel);
            Excliur(obj);
        }

        public void Excluir(T objeto)
        {
            _contexto.Set<T>().Remove(objeto);
            if (_SaveChanges)
            {
                _contexto.SaveChanges();
            }
        }

        public T Incluir(T objeto)
        {
            _contexto.Set<T>().Add(objeto);
            if(_SaveChanges)
            {
                _contexto.SaveChanges();
            }
            return objeto;
        }

        public void SaveChanges()
        {
            _contexto.SaveChanges();
        }

        public T SelecionarPk(params object[] variavel)
        {
            return _contexto.Set<T>().Find(variavel);
        }

        public List<T> SelecionarTodos()
        {
            return _contexto.Set<T>().ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ProjetoIndividual.Dominio.Interfaces.Repository
{
    public interface IRepository<TEntity>: IDisposable where TEntity : class
    {
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPorId(int id);
        TEntity Adicionar(TEntity obj);
        TEntity Atualizar(TEntity obj);
        void Remover(int id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
    }
}

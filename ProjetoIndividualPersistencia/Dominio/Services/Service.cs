using ProjetoIndividual.Dominio.Interfaces;
using ProjetoIndividual.Dominio.Interfaces.Repository;
using ProjetoIndividual.Dominio.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace ProjetoIndividual.Dominio.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            //Regras de negócio gerais entram aqui
            if (obj != null)
                _repository.Adicionar(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.ObterTodos();
        }

        public TEntity GetById(int id)
        {
            return _repository.ObterPorId(id);
        }

        public void Remove(int id)
        {
            _repository.Remover(id);
        }

        public void Update(TEntity obj)
        {
            _repository.Atualizar(obj);
        }
    }
}

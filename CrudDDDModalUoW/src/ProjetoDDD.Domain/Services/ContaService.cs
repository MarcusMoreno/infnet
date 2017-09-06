using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repository;
using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Services
{
   public class ContaService : IContaService
    {
        private readonly IContaRepository _contaRepository;
      //  private readonly IPerfilRepository _perfilRepository;

        public ContaService(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
           // _perfilRepository =perfilRepository;
        }

        public Conta Adicionar(Conta conta)
        {
            if (conta == null)
            {
                return conta;
            }           
            return _contaRepository.Adicionar(conta);
        }

        public Conta ObterPorId(Guid id)
        {
            return _contaRepository.ObterPorId(id);
        }

        public Conta ObterPorNome(string nome)
        {
            return _contaRepository.ObterPorNome(nome);
        }
        

        public IEnumerable<Conta> ObterTodos()
        {
            return _contaRepository.ObterTodos();
        }

        public Conta Atualizar(Conta conta)
        {
            return _contaRepository.Atualizar(conta);
        }

        public void Remover(Guid id)
        {
            _contaRepository.Remover(id);
        }

        //public Perfil AdicionarEndereco(Perfil perfil)
        //{
        //    return _perfilRepository.Adicionar(perfil);
        //}

        //public Perfil AtualizarPerfil(Perfil perfil)
        //{
        //    return _perfilRepository.Atualizar(perfil);
        //}

        //public Perfil ObterPerfilPorId(Guid id)
        //{
        //    return _perfilRepository.ObterPorId(id);
        //}

        //public void RemoverPerfil(Guid id)
        //{
        //    _perfilRepository.Remover(id);
        //}

        public void Dispose()
        {
            _contaRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

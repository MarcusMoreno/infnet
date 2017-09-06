using ProjetoDDD.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Application.Interfaces
{
    interface IContaAppService : IDisposable
    {
        ContaViewModel Adicionar(ContaViewModel contaViewModel);
        ContaViewModel ObterPorId(Guid id);
        ContaViewModel ObterPorNome(string nome);
        IEnumerable<ContaViewModel> ObterTodos();
        ContaViewModel Atualizar(ContaViewModel contaViewModel);
        void Remover(Guid id);

        //EnderecoViewModel AdicionarEndereco(EnderecoViewModel enderecoViewModel);
        //EnderecoViewModel AtualizarEndereco(EnderecoViewModel enderecoViewModel);
        //EnderecoViewModel ObterEnderecoPorId(Guid id);
        //void RemoverEndereco(Guid id);
    }
}
using Dominio.Interfaces;
using Dominio.Servicos.Interfaces;

namespace Dominio.Servicos
{
    public class ProdutoServico : Servico<Produto>, IProdutoServico
    {

        public ProdutoServico(IProdutoRepositorio produtoRepositorio) : base(produtoRepositorio)
        {

        }

    }
}

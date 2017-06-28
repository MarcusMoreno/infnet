using ProjetoIndividual.Dominio.Interfaces;
using ProjetoIndividual.Dominio.Servicos.Interfaces;

namespace ProjetoIndividual.Dominio.Servicos
{
    public class ProdutoServico : Servico<Produto>, IProdutoServico
    {

        public ProdutoServico(IProdutoRepository produtoRepository) : base(produtoRepository)
        {

        }

    }
}

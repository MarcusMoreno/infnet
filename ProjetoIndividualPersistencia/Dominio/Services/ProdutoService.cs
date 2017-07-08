using ProjetoIndividual.Dominio.Interfaces.Repository;
using ProjetoIndividual.Dominio.Interfaces.Service;

namespace ProjetoIndividual.Dominio.Services
{
    public class ProdutoService : Service<Produto>, IProdutoService
    {

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {

        }

    }
}

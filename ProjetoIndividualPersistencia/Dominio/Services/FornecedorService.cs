using ProjetoIndividual.Dominio.Interfaces.Repository;
using ProjetoIndividual.Dominio.Interfaces.Service;

namespace ProjetoIndividual.Dominio.Services
{
    public class FornecedorService : Service<Fornecedor>, IFornecedorService
    {

        //private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository) : base(fornecedorRepository)
        {

        }

    }
}

using ProjetoIndividual.Dominio.Interfaces.Repository;
using ProjetoIndividual.Dominio.Interfaces.Service;
using ProjetoIndividual.Dominio.Services;

namespace ProjetoIndividual.Dominio.Servicos
{
    public class FornecedorService : Service<Forncedor>, IFornecedorService
    {

        //private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository) : base(fornecedorRepository)
        {

        }

    }
}

using ProjetoIndividual.Dominio.Interfaces;
using ProjetoIndividual.Dominio.Servicos.Interfaces;

namespace ProjetoIndividual.Dominio.Servicos
{
    public class FornecedorServico : Servico<Forncedor>, IFornecedorServico
    {

        //private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorServico(IFornecedorRepository fornecedorRepository) : base(fornecedorRepository)
        {

        }

    }
}

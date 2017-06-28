using Dominio.Servicos.Interfaces;
using ProjetoIndividual.Dominio.Interfaces.Repository;
using ProjetoIndividual.Dominio.Services;

namespace ProjetoIndividual.Dominio.Servicos
{
    public class EnderecoService : Service<Endereco>, IEnderecoService
    {
        public EnderecoService(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
                
        }
    }
}

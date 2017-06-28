using Dominio.Servicos.Interfaces;
using ProjetoIndividual.Dominio.Interfaces;

namespace ProjetoIndividual.Dominio.Servicos
{
    public class EnderecoServico : Servico<Endereco>, IEnderecoServico
    {
        public EnderecoServico(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
                
        }
    }
}

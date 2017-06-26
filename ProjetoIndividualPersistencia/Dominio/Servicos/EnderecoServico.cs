using Dominio.Interfaces;
using Dominio.Servicos.Interfaces;

namespace Dominio.Servicos
{
    public class EnderecoServico : Servico<Endereco>, IEnderecoServico
    {
        public EnderecoServico(IEnderecoRepositorio enderecoRepositorio) : base(enderecoRepositorio)
        {
                
        }
    }
}

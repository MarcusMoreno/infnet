using Dominio.Interfaces;
using Dominio.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public class EnderecoServico : Servico<Endereco>, IEnderecoServico
    {
        public EnderecoServico(IEnderecoRepositorio enderecoRepositorio) : base(enderecoRepositorio)
        {
                
        }
    }
}

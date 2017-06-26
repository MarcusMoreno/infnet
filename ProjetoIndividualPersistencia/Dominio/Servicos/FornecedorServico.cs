using Dominio.Interfaces;
using Dominio.Servicos.Interfaces;

namespace Dominio.Servicos
{
    public class FornecedorServico : Servico<Forncedor>, IFornecedorServico
    {

        //private readonly IFornecedorRepositorio _fornecedorRepositorio;

        public FornecedorServico(IFornecedorRepositorio fornecedorRepositorio) : base(fornecedorRepositorio)
        {

        }

    }
}

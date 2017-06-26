using Dominio.Interfaces;
using Dominio.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public class FornecedorService : Servico<Forncedor>, IFornecedorServico
    {

        //private readonly IFornecedorRepositorio _fornecedorRepositorio;

        public FornecedorService(IFornecedorRepositorio fornecedorRepositorio) : base(fornecedorRepositorio)
        {

        }

    }
}

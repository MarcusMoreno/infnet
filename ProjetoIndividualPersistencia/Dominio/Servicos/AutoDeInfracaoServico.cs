using Dominio.Interfaces;
using Dominio.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public class AutoDeInfracaoServico : Servico<AutoDeInfracao>, IAutoDeInfracaoServico
    {
        public AutoDeInfracaoServico(IAutoDeInfracaoRepositorio autoDeInfracaoRepositorio) : base (autoDeInfracaoRepositorio)
        {
          
        }
    }
}

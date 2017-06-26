using Dominio.Interfaces;
using Dominio.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
   public class ProcessoServico : Servico<Processo>, IProcessoServico
    {
        public ProcessoServico(IProcessoRepositorio processoRepositorio) : base(processoRepositorio)
        {

        }
    }
}

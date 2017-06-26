using Dominio.Interfaces;
using Dominio.Servicos.Interfaces;

namespace Dominio.Servicos
{
    public class ProcessoServico : Servico<Processo>, IProcessoServico
    {
        public ProcessoServico(IProcessoRepositorio processoRepositorio) : base(processoRepositorio)
        {

        }
    }
}

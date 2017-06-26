using Dominio.Interfaces;
using Dominio.Servicos.Interfaces;

namespace Dominio.Servicos
{
    public class AutoDeInfracaoServico : Servico<AutoDeInfracao>, IAutoDeInfracaoServico
    {
        public AutoDeInfracaoServico(IAutoDeInfracaoRepositorio autoDeInfracaoRepositorio) : base (autoDeInfracaoRepositorio)
        {
          
        }
    }
}

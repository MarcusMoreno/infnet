using Dominio.Servicos.Interfaces;
using ProjetoIndividual.Dominio.Interfaces;

namespace ProjetoIndividual.Dominio.Servicos
{
    public class AutoDeInfracaoServico : Servico<AutoDeInfracao>, IAutoDeInfracaoServico
    {
        public AutoDeInfracaoServico(IAutoDeInfracaoRepository autoDeInfracaoRepository) : base (autoDeInfracaoRepository)
        {
          
        }
    }
}

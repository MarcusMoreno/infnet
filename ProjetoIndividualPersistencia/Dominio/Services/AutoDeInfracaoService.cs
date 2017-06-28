using Dominio.Servicos.Interfaces;
using ProjetoIndividual.Dominio.Interfaces;
using ProjetoIndividual.Dominio.Interfaces.Repository;
using ProjetoIndividual.Dominio.Services;

namespace ProjetoIndividual.Dominio.Servicos
{
    public class AutoDeInfracaoService : Service<AutoDeInfracao>, IAutoDeInfracaoService
    {
        public AutoDeInfracaoService(IAutoDeInfracaoRepository autoDeInfracaoRepository) : base (autoDeInfracaoRepository)
        {
          
        }
    }
}

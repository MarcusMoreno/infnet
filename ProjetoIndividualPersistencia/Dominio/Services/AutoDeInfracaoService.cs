using Dominio.Servicos.Interfaces;
using ProjetoIndividual.Dominio.Interfaces.Repository;

namespace ProjetoIndividual.Dominio.Services
{
    public class AutoDeInfracaoService : Service<AutoDeInfracao>, IAutoDeInfracaoService
    {
        public AutoDeInfracaoService(IAutoDeInfracaoRepository autoDeInfracaoRepository) : base(autoDeInfracaoRepository)
        {


        }
    }
}

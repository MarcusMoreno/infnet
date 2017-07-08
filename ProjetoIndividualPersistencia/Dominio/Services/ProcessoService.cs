using ProjetoIndividual.Dominio.Interfaces.Repository;
using ProjetoIndividual.Dominio.Interfaces.Service;

namespace ProjetoIndividual.Dominio.Services
{
    public class ProcessoService : Service<Processo>, IProcessoService
    {
        public ProcessoService(IProcessoRepository processoRepository) : base(processoRepository)
        {

        }
    }
}

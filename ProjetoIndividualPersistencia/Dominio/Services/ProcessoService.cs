using ProjetoIndividual.Dominio.Interfaces.Repository;
using ProjetoIndividual.Dominio.Interfaces.Service;
using ProjetoIndividual.Dominio.Services;

namespace ProjetoIndividual.Dominio.Servicos
{
    public class ProcessoService : Service<Processo>, IProcessoService
    {
        public ProcessoService(IProcessoRepository processoRepository) : base(processoRepository)
        {

        }
    }
}

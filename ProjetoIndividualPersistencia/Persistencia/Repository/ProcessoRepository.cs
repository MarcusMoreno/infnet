using ProjetoIndividual.Dominio;
using ProjetoIndividual.Dominio.Interfaces.Repository;
using System.Data.Entity;

namespace Persistencia.Repository
{
    public class ProcessoRepository : Repository<Processo>, IProcessoRepository
    {
        public ProcessoRepository(DbContext context ) : base(context)
        {

        }
    }
}

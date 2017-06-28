using ProjetoIndividual.Dominio;
using ProjetoIndividual.Dominio.Interfaces;
using System.Data.Entity;

namespace Persistencia.Repository
{
    public class AutoDeInfracaoRepository : Repository<AutoDeInfracao>, IAutoDeInfracaoRepository
    {

        public AutoDeInfracaoRepository(DbContext context ) : base (context)
        {

        }
    }
}

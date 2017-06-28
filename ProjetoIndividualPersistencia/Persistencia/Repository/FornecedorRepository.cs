using ProjetoIndividual.Dominio;
using ProjetoIndividual.Dominio.Interfaces.Repository;
using System.Data.Entity;

namespace Persistencia.Repository
{
    public class FornecedorRepository : Repository<Forncedor>, IFornecedorRepository
    {
        public FornecedorRepository(DbContext context) : base(context)
        {

        }
        
    }
}

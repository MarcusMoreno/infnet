using ProjetoIndividual.Dominio;
using ProjetoIndividual.Dominio.Interfaces;
using System.Data.Entity;

namespace Persistencia.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(DbContext context) : base(context)
        {

        }
    }
}

using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repository;
using ProjetoDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Data.Repository
{
    public class PerfilRepository : Repository<Perfil>, IPerfilRepository
    {

        public PerfilRepository(ProjetoDDDContext context)
            : base(context)
        {

        }

        /// <summary>
        /// Busca por nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public Perfil ObterPorNome(string nome)
        {
            return Buscar(c => c.Nome == nome).FirstOrDefault();
        }


        /// <summary>
        /// Busca todos
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Perfil> ObterTodos()
        {
            return ObterTodos();
        }

    }
}

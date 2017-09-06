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
    public class PublicacaoRepository : Repository<Publicacao>, IPublicacaoRepository
    {

        public PublicacaoRepository(ProjetoDDDContext context)
        : base(context)
        {

        }

        /// <summary>
        /// Busca por nome
        /// </summary>
        /// <param name="conteudo"></param>
        /// <returns></returns>
        public Publicacao ObterPorConteudo(string conteudo)
        {
            return Buscar(c => c.Conteudo == conteudo).FirstOrDefault();
        }


        /// <summary>
        /// Busca todos
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Publicacao> ObterTodos()
        {
            return ObterTodos();
        }
    }
}

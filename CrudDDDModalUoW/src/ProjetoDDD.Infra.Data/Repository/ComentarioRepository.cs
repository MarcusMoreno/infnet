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
    public class ComentarioRepository : Repository<Comentario>, IComentarioRepository
    {

        public ComentarioRepository(ProjetoDDDContext context)
        : base(context)
        {

        }

        /// <summary>
        /// Busca por nome
        /// </summary>
        /// <param name="conteudo"></param>
        /// <returns></returns>
        public Comentario ObterPorComentario(string comentario)
        {
            return Buscar(c => c.ComentarioField == comentario).FirstOrDefault();
        }


        /// <summary>
        /// Busca todos
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Comentario> ObterTodos()
        {
            return ObterTodos();
        }
    }
}

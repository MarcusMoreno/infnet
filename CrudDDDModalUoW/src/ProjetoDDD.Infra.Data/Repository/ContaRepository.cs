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
    public class ContaRepository : Repository<Conta>, IContaRepository
    {

        public ContaRepository(ProjetoDDDContext context)
            : base(context)
        {

        }

        /// <summary>
        /// Busca por nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public Conta ObterPorNome(string nome)
        {
            return Buscar(c => c.NomeUsuario == nome).FirstOrDefault();
        }

     
        /// <summary>
        /// Busca todas as contas
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Conta> ObterTodos()
        {
            return ObterTodos();
        }

        /// <summary>
        /// Busca conta por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override Conta ObterPorId(Guid id)
        {
            return Buscar(c => c.ContaId == id).FirstOrDefault();
        }
    }
}

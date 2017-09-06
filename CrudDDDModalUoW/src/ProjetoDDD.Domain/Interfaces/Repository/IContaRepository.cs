using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Interfaces.Repository
{
   public  interface IContaRepository : IRepository<Conta>
    {
        Conta ObterPorNome(string nome);
      
    }
}

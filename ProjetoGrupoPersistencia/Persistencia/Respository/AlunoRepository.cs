using Dominio.Entities;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Respository
{
   public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(DbContext contex) : base (contex)
        {

        }
    }
}

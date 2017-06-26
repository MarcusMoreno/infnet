using Dominio;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repositorio
{
   public class ProcessoRepositorio : Repositorio<Processo>, IProcessoRepositorio
    {
        public ProcessoRepositorio(DbContext context ) : base(context)
        {

        }
    }
}

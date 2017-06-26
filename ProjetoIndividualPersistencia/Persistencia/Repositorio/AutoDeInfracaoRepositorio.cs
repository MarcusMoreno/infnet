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
     public class AutoDeInfracaoRepositorio : Repositorio<AutoDeInfracao>, IAutoDeInfracaoRepositorio
    {

        public AutoDeInfracaoRepositorio(DbContext context ) : base (context)
        {

        }
    }
}

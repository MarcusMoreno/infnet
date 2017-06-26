using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominio;
using Dominio.Interfaces;

namespace Persistencia.Repositorio
{
    public class FornecedorRepositorio : Repositorio<Forncedor>, IFornecedorRepositorio
    {
        public FornecedorRepositorio(DbContext context) : base(context)
        {

        }
        
    }
}

using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Configuracao
{
    class AutoDeInfracaoConfig : EntityTypeConfiguration<AutoDeInfracao>
    {
        public AutoDeInfracaoConfig()
        {
            ToTable("AutoDeInfracao");
        }
        
    }
}

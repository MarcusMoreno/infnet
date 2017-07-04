using Dominio;
using ProjetoIndividual.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIndividual.Persistencia.Configs
{
    class AutoDeInfracaoConfig : EntityTypeConfiguration<AutoDeInfracao>
    {
        public AutoDeInfracaoConfig()
        {
            ToTable("AutoDeInfracao");
            HasKey(x => x.Id);

        }
        
    }
}

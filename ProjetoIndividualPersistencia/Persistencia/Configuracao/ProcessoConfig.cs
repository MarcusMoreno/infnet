using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia.Configuracao
{
    public class ProcessoConfig : EntityTypeConfiguration<Processo>
    {
        public ProcessoConfig()
        {
            ToTable("Processo");

           




        }
    }
}

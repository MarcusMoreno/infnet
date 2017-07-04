using ProjetoIndividual.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoIndividual.Persistencia.Configs
{
    public class ProcessoConfig : EntityTypeConfiguration<Processo>
    {
        public ProcessoConfig()
        {
            ToTable("Processo");

            HasKey(x => x.Id);

            HasRequired(x => x.Fornecedor);



        }
    }
}

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

            //Relação 1:N -> Processo PRECISA TER um Fornecedor e 1 Fornecedor pode ter N processos
            HasRequired(a => a.Fornecedor)
                .WithMany()
                .Map(m => m.MapKey("FormcedorId"));



        }
    }
}

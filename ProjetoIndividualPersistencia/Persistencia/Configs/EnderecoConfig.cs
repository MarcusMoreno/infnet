using ProjetoIndividual.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoIndividual.Persistencia.Configs
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            ToTable("Endereco");
            HasKey(x => x.Id);
           
            //Relação 1:N -> Endereco PRECISA TER um Fornecedor e 1 Fornecedor pode ter N enderecos
            HasRequired(a => a.Fornecedor)
                .WithMany()
                .Map(m => m.MapKey("FormcedorId"));

        }
    }
}

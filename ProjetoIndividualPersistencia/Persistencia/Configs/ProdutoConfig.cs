using ProjetoIndividual.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoIndividual.Persistencia.Configs
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            ToTable("Produto");
            HasKey(a => a.Id);

            //Relação 1:N -> Produto PRECISA TER um Fornecedor e 1 Fornecedor pode ter N produtos
            HasRequired(a => a.Fornecedor)
                .WithMany()
                .Map(m => m.MapKey("FormcedorId"));




        }
    }
}

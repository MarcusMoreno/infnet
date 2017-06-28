using ProjetoIndividual.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoIndividual.Persistencia.Configs
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            ToTable("Produto");
            HasKey(a => a.Ean);




        }
    }
}

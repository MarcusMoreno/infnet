using ProjetoIndividual.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoIndividual.Persistencia.Configs
{
    public class FornecedorConfig : EntityTypeConfiguration<Forncedor>
    {
        public FornecedorConfig()
        {
            ToTable("Fornecedor");
            HasKey(a => a.Cnpj);
          
           
            Property(c => c.Cnpj).IsRequired().HasMaxLength(14);
            Property(c => c.RazaoSocial).IsRequired().HasMaxLength(200);
            //Property(x => x.Enderecos).IsRequired();
            Property(x => x.ReceitaBruta).IsRequired();
            Property(x => x.InscricaoMunicipal).HasMaxLength(8);

            
        }
    }
}

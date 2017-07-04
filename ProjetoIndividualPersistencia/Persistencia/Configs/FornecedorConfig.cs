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
            HasRequired(x => x.Enderecos);
            Property(x => x.ReceitaBruta).IsRequired();
            Property(x => x.InscricaoMunicipal).HasMaxLength(8);

            HasMany(x => x.Produtos);
            HasMany(x => x.Processos);
            HasMany(x => x.Enderecos).WithRequired();
                
            
        }
    }
}

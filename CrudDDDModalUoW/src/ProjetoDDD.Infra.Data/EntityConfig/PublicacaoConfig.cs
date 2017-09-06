using ProjetoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDD.Infra.Data.EntityConfig
{
    public class PublicacaoConfig : EntityTypeConfiguration<Publicacao>
    {
        public PublicacaoConfig()
        {
            ToTable("Publicacoes");
        }
    }
}

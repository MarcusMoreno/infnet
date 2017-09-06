using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Data.EntityConfig
{
    public class ContaConfig : EntityTypeConfiguration<Conta>
    {
        public ContaConfig()
        {
            HasKey(c => c.ContaId);

            Property(c => c.NomeUsuario)
               .IsRequired()
               .HasMaxLength(150);

            Property(c => c.Senha)
               .IsRequired();

            ToTable("Contas");
        }
    }
}

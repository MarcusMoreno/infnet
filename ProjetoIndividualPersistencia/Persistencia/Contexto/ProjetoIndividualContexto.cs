using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Contexto
{
    public class ProjetoIndividualContexto : DbContext
    {
        public ProjetoIndividualContexto() : base()
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
            modelBuilder.Properties<String>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<String>().Configure(p => p.HasMaxLength(100));

            //modelBuilder.Configurations.Add(new ClienteConfiguration());
            //modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }

        public DbSet<AutoDeInfracao> AutoDeInfracoes { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Forncedor> Fornecedores { get; set; }

        public DbSet<Processo> Processos { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        
    }
}

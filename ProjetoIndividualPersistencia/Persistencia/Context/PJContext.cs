using ProjetoIndividual.Dominio;
using ProjetoIndividual.Persistencia.Configs;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;



namespace ProjetoIndividual.Persistencia.Context
{
    public class PJContext : DbContext
    {
        public PJContext() : base()
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

            /*
            Adicionar configurações específicas por entidade:
            */
            modelBuilder.Configurations.Add(new AutoDeInfracaoConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new FornecedorConfig());
            modelBuilder.Configurations.Add(new ProcessoConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());
        }

        public DbSet<AutoDeInfracao> AutoDeInfracoes { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Forncedor> Forncedores { get; set; }

        public DbSet<Processo> Processos { get; set; }

        public DbSet<Produto> Produtos { get; set; }

    }
}

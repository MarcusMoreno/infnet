using System.Data.Entity.Migrations;
using ProjetoDDD.Infra.Data.Context;

namespace ProjetoDDD.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoDDDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProjetoDDDContext context)
        {
        }
    }
}

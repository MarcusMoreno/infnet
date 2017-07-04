using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoIndividual.Dominio;
using ProjetoIndividual.Persistencia.Context;
using ProjetoIndividual.Dominio.Interfaces.Repository;
using Persistencia.Repository;

namespace Tests
{
    [TestClass]
    public class ProdutoTest
    {
        //DbContext db = new SisAcadDbContext();
        //BIProdutoRepository IProdutoRepository = new ProdutoRepository(db);

        [TestMethod]
        public void AddProdutoTests()
        {
            Produto p = new Produto();
            p.Nome = "NomeProduto";
            p.Marca = "NomeMarca";
            p.Estoque = "21";
            

        }
    }
}

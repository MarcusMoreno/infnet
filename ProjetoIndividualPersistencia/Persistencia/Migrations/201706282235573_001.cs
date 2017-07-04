namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AutoDeInfracao",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 100, unicode: false),
                        Gravidade = c.Int(nullable: false),
                        Atenuante = c.Boolean(nullable: false),
                        Agravante = c.Boolean(nullable: false),
                        Multa = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Processo_Id = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Processo", t => t.Processo_Id)
                .Index(t => t.Processo_Id);
            
            CreateTable(
                "dbo.Processo",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 100, unicode: false),
                        RelatoFiscalizacao_Capacity = c.Int(nullable: false),
                        RelatoFiscalizacao_Length = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        FiscalResponsavel = c.String(maxLength: 100, unicode: false),
                        Fornecedor_Cnpj = c.String(maxLength: 14, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fornecedor", t => t.Fornecedor_Cnpj)
                .Index(t => t.Fornecedor_Cnpj);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        Cnpj = c.String(nullable: false, maxLength: 14, unicode: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 200, unicode: false),
                        InscricaoMunicipal = c.String(maxLength: 8, unicode: false),
                        ReceitaBruta = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Cnpj);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 100, unicode: false),
                        Logradouro = c.String(maxLength: 100, unicode: false),
                        Numero = c.String(maxLength: 100, unicode: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Bairro = c.String(maxLength: 100, unicode: false),
                        Municipio = c.String(maxLength: 100, unicode: false),
                        Cep = c.String(maxLength: 100, unicode: false),
                        Uf = c.String(maxLength: 100, unicode: false),
                        Forncedor_Cnpj = c.String(maxLength: 14, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fornecedor", t => t.Forncedor_Cnpj)
                .Index(t => t.Forncedor_Cnpj);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 100, unicode: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Marca = c.String(maxLength: 100, unicode: false),
                        Estoque = c.String(maxLength: 100, unicode: false),
                        Forncedor_Cnpj = c.String(maxLength: 14, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fornecedor", t => t.Forncedor_Cnpj)
                .Index(t => t.Forncedor_Cnpj);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AutoDeInfracao", "Processo_Id", "dbo.Processo");
            DropForeignKey("dbo.Produto", "Forncedor_Cnpj", "dbo.Fornecedor");
            DropForeignKey("dbo.Processo", "Fornecedor_Cnpj", "dbo.Fornecedor");
            DropForeignKey("dbo.Endereco", "Forncedor_Cnpj", "dbo.Fornecedor");
            DropIndex("dbo.Produto", new[] { "Forncedor_Cnpj" });
            DropIndex("dbo.Endereco", new[] { "Forncedor_Cnpj" });
            DropIndex("dbo.Processo", new[] { "Fornecedor_Cnpj" });
            DropIndex("dbo.AutoDeInfracao", new[] { "Processo_Id" });
            DropTable("dbo.Produto");
            DropTable("dbo.Endereco");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.Processo");
            DropTable("dbo.AutoDeInfracao");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIndividual.Dominio
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            Enderecos = new List<Endereco>();
            Produtos = new List<Produto>();
            Processos = new List<Processo>();
        }

        public string Cnpj { get; set; }

        public string RazaoSocial { get; set; }

        public string InscricaoMunicipal { get; set; }

        public Decimal ReceitaBruta { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
        
        public virtual ICollection<Produto> Produtos { get; set; }

        public virtual ICollection<Processo> Processos { get; set; }






    }
}

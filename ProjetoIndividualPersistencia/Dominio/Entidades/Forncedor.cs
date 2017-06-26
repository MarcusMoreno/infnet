using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Forncedor
    {
        public string Cnpj { get; set; }

        public string RazaoSocial { get; set; }

        public string InscricaoMunicipal { get; set; }

        public Decimal ReceitaBruta { get; set; }

        public ICollection<Endereco> Enderecos { get; set; }
        
        public ICollection<Produto> Produtos { get; set; }

        public ICollection<Processo> Processos { get; set; }






    }
}

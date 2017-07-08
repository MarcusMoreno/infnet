using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIndividual.Dominio
{
    public class Processo
    {
        public Processo()
        {
            Fornecedor = new Fornecedor();
        }

        public string Id { get; set; }

        public string RelatoFiscalizacao { get; set; }

        public DateTime DataRelato { get; set; }

        public string FiscalResponsavel { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        
    }
}

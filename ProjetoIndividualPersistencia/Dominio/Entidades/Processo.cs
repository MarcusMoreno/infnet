using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIndividual.Dominio
{
    public class Processo
    {
        public string Id { get; set; }

        public Forncedor Fornecedor { get; set; }

        public StringBuilder RelatoFiscalizacao { get; set; }

        public DateTime Date { get; set; }

        public string FiscalResponsavel { get; set; }

    }
}

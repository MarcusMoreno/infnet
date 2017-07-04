using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIndividual.Dominio
{
    public class AutoDeInfracao
    {
        public string Id { get; set; }

        public Processo Processo { get; set; }

        public int Gravidade { get; set; }

        public Boolean Atenuante { get; set; }

        public Boolean Agravante { get; set; }

        public Decimal Multa { get; set; }
    }
}

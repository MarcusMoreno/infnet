using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
   public class Curso
    {
        public string Id { get; set; }

        public string Descricao { get; set; }

        public ICollection<Turma> Turmas { get; set; }
    }
}

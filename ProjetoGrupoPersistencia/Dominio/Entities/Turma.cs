using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Turma
    {
        public string Id { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
    }
}

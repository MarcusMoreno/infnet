using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Entities
{
   public class Perfil
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Local { get; set; }

        public Conta Conta { get; set; }

        public ICollection<Publicacao> Publicacoes { get; set; }

        public ICollection<Comentario> Comentarios { get; set; }
    }
}

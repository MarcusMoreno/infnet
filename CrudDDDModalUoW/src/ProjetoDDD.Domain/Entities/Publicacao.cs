using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Entities
{
    public class Publicacao
    {
        public string Conteudo { get; set; }

        public Perfil Perfil { get; set; }

        public ICollection<Comentario>  Comentarios { get; set; }
    }
}

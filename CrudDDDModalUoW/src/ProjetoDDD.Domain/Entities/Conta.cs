using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Entities
{
    public class Conta
    {
        public Guid ContaId { get; set; }

        public string NomeUsuario { get; set; }

        public string Senha { get; set; }

        public Perfil Perfil { get; set; }


       
    }
}

using ProjetoDDD.Domain.Interfaces.Repository;
using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Services
{
   public class ComentarioService : IComentarioService
    {
        private readonly IComentarioRepository _comentarioRepository;

        public ComentarioService(IComentarioRepository comentarioRespository)
        {
            _comentarioRepository = comentarioRespository;
        }

        public void Dispose()
        {
            _comentarioRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

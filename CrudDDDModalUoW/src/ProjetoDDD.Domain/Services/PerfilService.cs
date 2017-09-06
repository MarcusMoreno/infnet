using ProjetoDDD.Domain.Interfaces.Repository;
using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Services
{
  public  class PerfilService : IPerfilService
    {
        private readonly IPerfilRepository _perfilRepository;
        public PerfilService(IPerfilRepository perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }

        public void Dispose()
        {
            _perfilRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}


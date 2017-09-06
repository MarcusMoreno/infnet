using ProjetoDDD.Domain.Interfaces.Repository;
using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Services
{
    public class PublicacaoService : IPublicacaoService
    {
        private readonly IPublicacaoRepository _publicacaoRepository;
        public PublicacaoService(IPublicacaoRepository publicacaoRepository)
        {
            _publicacaoRepository = publicacaoRepository;
        }

        public void Dispose()
        {
            _publicacaoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

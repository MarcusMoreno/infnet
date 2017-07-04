using Dominio.Servicos.Interfaces;
using ProjetoIndividual.Dominio.Interfaces;
using ProjetoIndividual.Dominio.Interfaces.Repository;
using ProjetoIndividual.Dominio.Services;

namespace ProjetoIndividual.Dominio.Servicos
{
    public class AutoDeInfracaoService : Service<AutoDeInfracao>, IAutoDeInfracaoService
    {
        public AutoDeInfracaoService(IAutoDeInfracaoRepository autoDeInfracaoRepository) : base (autoDeInfracaoRepository)
        {
          
        }

        const decimal penaBase = 500;
        const decimal ufir = 3;
        

        public void CalcularMulta(decimal receitaBruta, bool ag, bool at)
        {
            var f = 0;
            var g = 1;

            if (ag)
            {
                f = 1;
            }
            if(at)
            {
                g = 033;
            }

            var b = ((receitaBruta - 120000) * 010) + 120000;
            var c = ufir * (f + g) * 0;
            var d = b * c;

            var m = penaBase + d;
        }
    }
}

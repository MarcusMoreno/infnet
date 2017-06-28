using ProjetoIndividual.Dominio.Interfaces;
using ProjetoIndividual.Dominio.Servicos.Interfaces;

namespace ProjetoIndividual.Dominio.Servicos
{
    public class ProcessoServico : Servico<Processo>, IProcessoServico
    {
        public ProcessoServico(IProcessoRepository processoRepository) : base(processoRepository)
        {

        }
    }
}

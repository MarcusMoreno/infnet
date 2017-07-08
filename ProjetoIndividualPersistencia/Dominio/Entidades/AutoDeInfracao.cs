using System;

namespace ProjetoIndividual.Dominio
{

    public class AutoDeInfracao
    {
        public AutoDeInfracao()
        {
            Processo = new Processo();
        }

        public string Id { get; set; }

        public int Gravidade { get; set; }

        public Boolean Atenuante { get; set; }

        public Boolean Agravante { get; set; }

        public Decimal Multa { get; set; }

        public virtual Processo Processo { get; set; }

        //Constantes
        private const decimal penaBase = 500m;
        private const decimal ufir = 3m;


        //Metodos
        public static decimal CalcularMulta(decimal receitaBruta, bool agravante, bool atenuante, int gravidade)
        {
            Decimal result = 0M;

            var valorAgravante = GetAgravanteValue(agravante);
            var valorAtenuante = GetAtenuanteValue(atenuante);

            result = penaBase + (((receitaBruta - 120000m) * 0.1m) + 120000m) * (ufir * (valorAgravante + valorAtenuante) * gravidade);

            return result;

        }

       
        public static decimal GetAgravanteValue(bool agravante)
        {
            if (agravante)
            {
                return 1;
            }

            return 0;
        }


        public static decimal GetAtenuanteValue(bool atenuante)
        {
            if (atenuante)
            {
                return 033;
            }

            return 1;
        }
    }
}

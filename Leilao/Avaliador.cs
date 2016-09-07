using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeilaoPrj
{
    public class Avaliador
    {
        private double maiorDeTodos = double.MinValue;
        private double menorDeTodos = double.MaxValue;
        private double media = 0;
        private List<Lance> maiores;

        /// <summary>
        /// realiza avaliação do leilão
        /// </summary>
        /// <param name="leilao"></param>
        public void Avalia(Leilao leilao)
        {
            if (leilao.Lances.Count == 0)
                throw new Exception("Não é possível avaliar um leilão sem lances");

            double total = 0;
            foreach(var lance in leilao.Lances)
            {
                if (lance.Valor > maiorDeTodos)
                    maiorDeTodos = lance.Valor;

                if (lance.Valor < menorDeTodos)
                    menorDeTodos = lance.Valor;

                total += lance.Valor;                
            }
            pegaOsMaioresNo(leilao);
            media = total / leilao.Lances.Count;
        }

        /// <summary>
        /// Busca os 3 meiores lances do leilão
        /// </summary>
        /// <param name="leilao"></param>
        private void pegaOsMaioresNo(Leilao leilao)
        {
            maiores = new List<Lance>(leilao.Lances.OrderByDescending(x => x.Valor));
            maiores = maiores.GetRange(0, maiores.Count > 3 ? 3 : maiores.Count);
            //maiores = maiores.GetRange(0, 3);
        }

        public List<Lance> TresMaiores
        {
            get { return this.maiores; }
        }

        /// <summary>
        /// retorna o maior lance do leilão
        /// </summary>
        public double MaiorLance
        {
            get { return maiorDeTodos; }
        }

        /// <summary>
        /// retorna o maior lance do leilão
        /// </summary>
        public double MenorLance
        {
            get { return menorDeTodos; }
         
        }
        
        /// <summary>
        /// Retorna o valor medio dos lances
        /// </summary>
        public double LanceMedio
        {
            get { return media; }
        }
    }
}

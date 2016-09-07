using System.Collections.Generic;
namespace LeilaoPrj
{

    public class Leilao
    {

        public string Descricao { get; set; }
        public IList<Lance> Lances { get; set; }

        /// <summary>
        /// realiza lances
        /// </summary>
        /// <param name="descricao"></param>
        public Leilao(string descricao)
        {
            this.Descricao = descricao;
            this.Lances = new List<Lance>();
        }

        public void Propoe(Lance lance)
        {
            Lances.Add(lance);
        }

    }
}
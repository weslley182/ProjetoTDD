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
            if (Lances.Count == 0 || podeDarLance(lance.Usuario))
            {
                Lances.Add(lance);
            }
        }

        private bool podeDarLance(Usuario usuario)
        {
            return !ultimoLanceDado().Usuario.Equals(usuario)
                && qtdDelancesDo(usuario) < 5;
        }

        private int qtdDelancesDo(Usuario usuario)
        {
            int total = 0;
            foreach (Lance lance in Lances)
            {
                if (lance.Usuario.Equals(usuario)) total++;
            }
            return total;
        }

        private Lance ultimoLanceDado()
        {
            return Lances[Lances.Count - 1];
        }

        public void DobrarLance(Usuario usuario)
        {
            Lance ultimoLance = ultimoLanceDo(usuario);
            if (ultimoLance != null)
            {
                Propoe(new Lance(usuario, ultimoLance.Valor * 2));
            }
        }

        private Lance ultimoLanceDo(Usuario usuario)
        {
            Lance ultimo = null;
            foreach (Lance lance in Lances)
            {
                if (lance.Usuario.Equals(usuario)) ultimo = lance;
            }

            return ultimo;
        }

    }
}
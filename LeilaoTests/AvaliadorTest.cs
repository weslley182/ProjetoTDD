using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LeilaoPrj;

namespace LeilaoTests
{
    [TestClass]
    public class AvaliadorTest
    {
        public Avaliador MontaCenario()
        {
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("José");
            Usuario maria = new Usuario("Maria");
            Usuario wesley = new Usuario("Wesley");
            Usuario will = new Usuario("Will");
            Usuario natalia = new Usuario("Natalia");
            Usuario cabecao = new Usuario("Cabeção");

            var leilao = new Leilao("Playstation 4 Novo");

            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(jose, 400.0));
            leilao.Propoe(new Lance(maria, 250.0));
            leilao.Propoe(new Lance(wesley, 25.0));
            leilao.Propoe(new Lance(will, 700.0));
            leilao.Propoe(new Lance(natalia, 1000.0));
            leilao.Propoe(new Lance(cabecao, 1000.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);
            return leiloeiro;
        }

        [TestMethod]
        public void TestaLancesDoLeilaoComValorCrescente()
        {
            var leiloeiro = MontaCenario();

            double maiorEsperado = 1000;
            double menorEsperado = 25;
            double diferencaAceitavel = 0.0001;

            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance, diferencaAceitavel);
            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance, diferencaAceitavel);
        }       

        [TestMethod]
        public void TestaValorMedioDosLances()
        {
            var leiloeiro = MontaCenario();
            double valorMedioEsperado = 525;            
            double diferencaAceitavel = 0.0001;

            Assert.AreEqual(valorMedioEsperado, leiloeiro.LanceMedio, diferencaAceitavel);
        }

        [TestMethod]
        public void DeveEntenderLeilaoComApenasUmLance()
        {
            Usuario joao = new Usuario("Joao");
            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 1000.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(1000, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(1000, leiloeiro.MenorLance, 0.0001);
        }

        [TestMethod]
        public void DeveEncontrarOsTresMaioresLances()
        {
            Usuario joao = new Usuario("João");
            Usuario maria = new Usuario("Maria");
            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 100.0));
            leilao.Propoe(new Lance(maria, 200.0));
            leilao.Propoe(new Lance(joao, 300.0));
            leilao.Propoe(new Lance(maria, 400.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            IList<Lance> maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400, maiores[0].Valor, 0.00001);
            Assert.AreEqual(300, maiores[1].Valor, 0.00001);
            Assert.AreEqual(200, maiores[2].Valor, 0.00001);
        }

        [TestMethod]
        public void DeveTestarLeilaoSemNenhumLance()
        {
            Usuario joao = new Usuario("João");            
            Leilao leilao = new Leilao("Playstation 3 Novo");

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            IList<Lance> maiores = leiloeiro.TresMaiores;
            Assert.AreEqual(0, maiores.Count);            
        }


        [TestMethod]
        public void DeveRetonarApenasDoisLances()
        {
            Usuario joao = new Usuario("João");
            Usuario maria = new Usuario("Maria");
            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.Propoe(new Lance(joao, 100.0));
            leilao.Propoe(new Lance(maria, 200.0));

            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            IList<Lance> maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(2, maiores.Count);
            Assert.AreEqual(200, maiores[0].Valor, 0.00001);
            Assert.AreEqual(100, maiores[1].Valor, 0.00001);            
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NaoDeveAvaliarLeiloesSemNenhumLanceDado()
        {
            Leilao leilao = new Leilao("Playstation 3 Novo");
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);            
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContaMaluca;

namespace ContaMalucaTests
{
    [TestClass]
    public class MatematicaTest
    {
        [TestMethod]
        public void DeveTestarMultipocadoPorQuatro()
        {
            var mat = new Matematica();
            var resultado = mat.ContaMaluca(50);
            Assert.AreEqual(200, resultado, 0.0001);
        }

        [TestMethod]
        public void DeveTestarMultipocadoPorTres()
        {
            var mat = new Matematica();
            var resultado = mat.ContaMaluca(11);
            Assert.AreEqual(33, resultado, 0.0001);
        }

        [TestMethod]
        public void DeveTestarMultipocadoPorDois()
        {
            var mat = new Matematica();
            var resultado = mat.ContaMaluca(5);
            Assert.AreEqual(10, resultado, 0.0001);
        }
    }
}

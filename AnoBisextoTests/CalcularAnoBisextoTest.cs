using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnoBisextoPrj;

namespace AnoBisextoTests
{
    [TestClass]
    public class CalcularAnoBisextoTest
    {
        [TestMethod]
        public void DeveRetornarEhAnoBisexto()
        {
            var calc = new CalcularAnoBisexto();
            Assert.IsTrue(calc.VerificarAnoBisexto(1996));
        }

        [TestMethod]
        public void DeveRetornarNaoEhAnoBisexto()
        {
            var calc = new CalcularAnoBisexto();
            Assert.IsFalse(calc.VerificarAnoBisexto(1997));
        }
    }
}

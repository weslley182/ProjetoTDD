using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculoNotaFiscalTests
{
    [TestClass]
    public class CalculaNotaFiscalTest
    {
        [TestMethod]
        public void TestaImpostoDaNotaFiscalCom20()
        {
            var nota = new NotaFiscal.NotaFiscal();
            nota.Valor = 1000;
            var calc = new NotaFiscal.CalculaNotaFiscal();
            var valor = calc.CalculaImposto(nota);
            Assert.AreEqual(20, valor, 0.0001);
        }
    }
}

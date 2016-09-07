using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeilaoPrj;

namespace TesteDeLeilao
{
    [TestClass]
    public class LanceTest
    {
        [TestMethod]        
        [ExpectedException(typeof(ArgumentException))]
        public void DeveRecusarLancesComValorDeZero()
        {
            new Lance(new Usuario("John Doe"), 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveRecusarLancesComValorNegativo()
        {
            new Lance(new Usuario("John Doe"), -10);
        }
    }
}

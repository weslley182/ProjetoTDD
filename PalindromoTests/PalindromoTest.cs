using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromoPrj;

namespace TesteDeLeilao
{
    [TestClass]
    public class PalindromoTest
    {
        [TestMethod]
        public void TestaFraseMaratona()
        {
            const string maratona = "Anotaram a data da maratona";
            var palin = new Palindromo();
            bool verdade = palin.EhPalindromo(maratona);
            Assert.IsTrue(verdade);
        }

        [TestMethod]
        public void TestaFraseMarrocos()
        {
            const string marrocos = "Socorram-me subi no onibus em Marrocos";
            var palin = new Palindromo();
            bool verdade = palin.EhPalindromo(marrocos);
            Assert.IsTrue(verdade);
        }
    }
}

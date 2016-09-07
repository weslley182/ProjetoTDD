using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromoPrj
{
    public class Palindromo
    {
        public bool EhPalindromo(string frase)
        {
            string fraseFiltrada = frase
                    .ToUpper().Replace(" ", "").Replace("-", "");

            for (int i = 0; i < fraseFiltrada.Length; i++)
            {
                int outroLado = fraseFiltrada.Length - i - 1;
                if (fraseFiltrada[i] != fraseFiltrada[outroLado])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

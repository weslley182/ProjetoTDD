using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaMaluca
{
    public class Matematica
    {
        public int ContaMaluca(int numero)
        {
            if (numero > 30)
                return numero * 4;
            else if (numero > 10)
                return numero * 3;
            else
                return numero * 2;
        }
    }
}

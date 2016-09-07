using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoBisextoPrj
{
    public class CalcularAnoBisexto
    {
        public bool VerificarAnoBisexto(int ano)
        {
            bool bissexto = false;

            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
                bissexto = true;

            return bissexto;
        }
    }
}

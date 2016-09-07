using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscal
{
    public class CalculaNotaFiscal
    {
        public double CalculaImposto(NotaFiscal nf)
        {
            if (nf.Valor > 2000)
                return nf.Valor * 0.03;

            return nf.Valor * 0.02;
        }
    }
}

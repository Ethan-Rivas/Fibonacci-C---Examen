using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Secuencia
    {
        public string Calculate(int limite)
        {
            ulong pivot;
            ulong a = 0;
            ulong b = 1;

            string secuencia = "";

            for (int i = 1; i <= limite; i++)
            {
                pivot = a;
                a = b;
                b = pivot + a;

                if (i < limite)
                    secuencia += pivot.ToString() + ", ";
                else
                    secuencia += pivot.ToString() + ".";
            }

            return secuencia;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGCD
{
    internal class Calcul
    {
        public static int CalculPGCD(int p, int q)
        {
            while (p != q)
            {
                if (p > q)
                {
                    p -= q;

                }
                else
                {
                    q -= p;
                }
            }

            return p;

        }
    }
}

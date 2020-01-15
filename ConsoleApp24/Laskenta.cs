using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp24
{
    public class Laskenta
    {
        public int Summa(int a, int b)
        {
            if ((a < 0) || (b < 0))
            {
                throw new ArgumentOutOfRangeException();
            }


            return a + b;
        }
    }
}

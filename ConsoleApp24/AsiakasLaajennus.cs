using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp24
{
    public static class AsiakasLaajennus
    {
        public static void UusiMetodi(this Asiakas a)
        {
            Console.WriteLine("Moi laajennusmetodista: " + a.Nimi);
        }
    }
}

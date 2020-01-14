using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ConsoleApp24
{
    public class Loki
    {
        public static void KirjoitaTiedostoon(string viesti)
        {
            string polku = @"C:\Temp\Sovellus.log";
            string merkintä = $"{DateTime.Now}: {viesti}\r\n";
            File.AppendAllText(polku, merkintä);

            Debug.WriteLine(merkintä);
            Trace.WriteLine(merkintä);
        }
    }
}

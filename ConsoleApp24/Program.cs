﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaLinqKieltä();
            LinqTesti2();



            /*
            int luku = LueLuku();



            KysySähköpostiosoite();
            Loki.KirjoitaTiedostoon("Sovellus käynnistyi");
            */

            #region Kommentoitua vanhaa koodia
            /*
            DateTime pvm = DateTime.Today;
            DateTime viikkoEteenpäin = pvm.AddDays(-7);

            DateTime alkuAika = DateTime.Now;
            for (int i = 0; i < 100; i++)
            {
                Loki.Kirjoita("Lokimerkintä " + i);
            }
            DateTime loppuAika = DateTime.Now;
            TimeSpan kesto = loppuAika - alkuAika;
            Console.WriteLine(kesto.TotalMilliseconds);
            */

            /*
            while (true)
            {
                Console.WriteLine("Syötä päivämäärä (pp.kk.vvvv):");
                string syöte = Console.ReadLine();

                CultureInfo enUs = new CultureInfo("en-US");

                bool onnistui = DateTime.TryParse(
                    syöte, enUs, DateTimeStyles.AssumeLocal, out DateTime pvm);
                if (onnistui)
                {
                    CultureInfo fiFi = new CultureInfo("fi-FI");
                    Console.WriteLine(pvm.ToString(fiFi));
                    break;
                }
                else
                {
                    Console.WriteLine("Päivämäärä ei ollut kelvollinen.");
                }
            }
            */

            /*
            DateTime pvm = DateTime.Parse(syöte);
            Console.WriteLine(pvm);
            */

            /*
            DateTime pvm = DateTime.Today;
            Console.WriteLine(pvm.ToString("d.M.yyyy"));
            DateTime nyt = DateTime.Now;
            Console.WriteLine(nyt.ToString("d.M.yyyy hh.mm.ss.fff"));

            CultureInfo enUs = new CultureInfo("en-US");
            CultureInfo fiFi = new CultureInfo("fi-FI");
            CultureInfo fr = new CultureInfo("fr");

            Console.WriteLine();
            Console.WriteLine(nyt.ToString(enUs));
            Console.WriteLine(nyt.ToString(fiFi));
            Console.WriteLine(nyt.ToString(fr));
            */

            //Console.WriteLine("Moikka!");
            //LaskeLukuja();
            //TiedostonKäsittely();
            //KeskiarvonLaskenta();
            //SähköpostienLuku();
            //Lukulista();
            #endregion

            Console.ReadLine();
            Loki.KirjoitaTiedostoon("Sovelluksen suoritus päättyi");

            /*
            int a = 123;
            int b = 234;
            if (a == b)
            {

            }

            string s = "abcd";
            string t = "abcd";
            if (s == t)
            {

            }
            */
        }

        private static void LinqTesti2()
        {
            /*
            Asiakas a = new Asiakas();
            a.UusiMetodi();
            AsiakasLaajennus.UusiMetodi(a);
            */

            List<Asiakas> asiakkaat = new List<Asiakas>()
            {
                new Asiakas()
                {
                    AsiakasId = 100,
                    Nimi = "Yritys Oy",
                    Yhteyshenkilö = "Antti Asiakas"
                },
                new Asiakas()
                {
                    AsiakasId = 101,
                    Nimi = "Toinen firma Oy",
                    Yhteyshenkilö = "K. Rosberg"
                },
                new Asiakas()
                {
                    AsiakasId = 102,
                    Nimi = "Kolmas Oy",
                    Yhteyshenkilö = "Maija Möttönen"
                },
            };

            // LINQ:n metodisyntaksi
            var kysely = asiakkaat.Where(a => a.AsiakasId == 101).AsQueryable();

            kysely = kysely.Where(a => a.Yhteyshenkilö.StartsWith("Antti"));

            var tulokset = kysely.ToList();

            // tulokset.ForEach(a => Console.WriteLine(a.Nimi));
            foreach (var asiakas in kysely)
            {
                Console.WriteLine(asiakas.Nimi);
            }
        }

        private static void TestaaLinqKieltä()
        {
            int[] luvut = { 3, 7, 11, 8, 2, 4, 5, 10, 3, 2, 6, 1 };
            int summa = luvut.Sum();

            /*
            // perinteinen tapa
            List<int> tulokset = new List<int>();
            foreach (int luku in luvut)
            {
                if (luku > 5)
                {
                    tulokset.Add(luku);
                }
            }
            tulokset.Sort();
            foreach (int luku in tulokset)
            {
                Console.WriteLine(luku);
            }
            */

            // LINQ = Language Integrated Query
            List<int> tulokset = (from l in luvut
                                  where l > 5
                                  orderby l
                                  select l).ToList();
            foreach (int luku in tulokset)
            {
                Console.WriteLine(luku);
            }
        }

        private static int LueLuku()
        {
            Console.WriteLine("Anna luku:");
            string syöte = Console.ReadLine();
            return int.Parse(syöte);
        }

        private static void KysySähköpostiosoite()
        {
            while (true)
            {
                Console.WriteLine("Anna sähköpostiosoite:");
                string email = Console.ReadLine();
                bool osoiteOK = TarkistaSähköpostiosoite(email);
                if (osoiteOK)
                {
                    Console.WriteLine("Osoite oli OK!");
                    break;
                }
                else
                {
                    Console.WriteLine("Osoite ei ollut kelvollinen sähköpostiosoite.");
                }
            }
        }

        private static bool TarkistaSähköpostiosoite(string email)
        {
            /*
            Regex regex = new Regex("[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,}");
            bool tulos = regex.IsMatch(email);
            return tulos;
            */

            try
            {
                MailAddress osoite = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static void Lukulista()
        {
            List<int> luvut = new List<int>() { 4, 8, 3, 10, 9, 2, 6, 7 };
            /*
            luvut.Add(4);
            luvut.Add(8);
            luvut.Add(3);
            // ...
            */

            int summa = 0;
            foreach (int luku in luvut)
            {
                summa += luku;
            }
            // int summa = luvut.Sum();

            List<string> nimet = new List<string>() { "Masa", "Keke", "Jaska" };
            // nimet.Add(1234);
            // nimet.Sum(); // ??
        }

        private static void SähköpostienLuku()
        {
            Loki.KirjoitaTiedostoon("Aloitetaan sähköpostien käsittely");

            Dictionary<string, string> sähköpostit = new Dictionary<string, string>();

            string polku = @"C:\Academy\Turku\DotNet\Sähköposteja.txt";
            string[] rivit = File.ReadAllLines(polku);
            foreach (string rivi in rivit)
            {
                string[] osat = rivi.Split(';');
                string nimi = osat[0];
                string email = osat[1];

                if (!sähköpostit.ContainsKey(email))
                {
                    sähköpostit.Add(email, nimi);
                }
                else
                {
                    //Console.WriteLine("Sähköpostiosoite " + email + " on jo listalla.");
                    Console.WriteLine($"Sähköpostiosoite {email} on jo listalla.");
                }
            }

            Console.WriteLine($"Tiedosto luettu, löytyi {sähköpostit.Count} uniikkia sähköpostia.");
        }


        /// <summary>
        /// Lukee tekstitiedoston ja laskee tiedoston lukujen keskiarvon.
        /// </summary>
        private static void KeskiarvonLaskenta()
        {
            // uusi kommentti

            string polku = @"C:\Academy\Turku\DotNet\Lukuja.txt";
            string[] rivit = File.ReadAllLines(polku);
            int summa = 0;
            foreach (string rivi in rivit)
            {
                int luku = int.Parse(rivi);
                summa += luku;
            }

            double ka = summa / rivit.Length;
            Console.WriteLine(ka.ToString("0.0"));
        }

        private static void TiedostonKäsittely()
        {
            FileStream fs = new FileStream(
                "C:\\Temp\\Tiedosto.txt", FileMode.CreateNew);

            string data = "Hello World!";
            byte[] tavut = Encoding.UTF8.GetBytes(data);
            fs.Write(tavut, 0, tavut.Length);

            //fs.Close();
            //fs.Dispose();
        }

        private static void LaskeLukuja()
        {
            string s = Console.ReadLine();
            int i = int.Parse(s);

            i += 1000;

            Console.WriteLine(i);
        }
    }
}

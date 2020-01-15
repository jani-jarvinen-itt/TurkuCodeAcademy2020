using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp24;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp24.Tests
{
    [TestClass()]
    public class LaskentaTests
    {
        [TestMethod()]
        public void SummaTest()
        {
            int[] a = { -2, -1, 0, 1, 2, 3, -1, 1 };
            int[] b = { -200, -100, 0, 100, 200, 300, 1, -1 };

            for (int indeksi = 0; indeksi < a.Length; indeksi++)
            {
                int luku1 = a[indeksi];
                int luku2 = b[indeksi];

                Debug.WriteLine($"Testitapaus {indeksi}: luvut = {luku1}, {luku2}.");

                try
                {
                    Laskenta l = new Laskenta();
                    int summa = l.Summa(luku1, luku2);

                    if ((luku1 < 0) || (luku2 < 0))
                    {
                        Assert.Fail();
                    }
                    else
                    {
                        int odotettu = luku1 + luku2;
                        Assert.AreEqual(odotettu, summa);
                    }
                }
                catch (Exception ex)
                {
                    if (!(ex is ArgumentOutOfRangeException))
                    {
                        Assert.Fail();
                    }
                }
            }
        }
    }
}
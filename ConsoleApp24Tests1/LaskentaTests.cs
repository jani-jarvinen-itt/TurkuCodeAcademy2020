using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp24;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24.Tests
{
    [TestClass()]
    public class LaskentaTests
    {
        [TestMethod()]
        public void SummaTest()
        {
            int a = -1;
            int b = -2;

            try
            {
                Laskenta l = new Laskenta();
                int summa = l.Summa(a, b);

                Assert.Fail();
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
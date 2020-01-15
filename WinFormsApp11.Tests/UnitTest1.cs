using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp11.Logiikka;
using WindowsFormsApp11.Models;
using WinFormsApp11.Tests.Mock;

namespace WinFormsApp11.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ITilauksenSumma rajapinta = new TilauksenSummaMock();
            List<Order_Details> rivit = rajapinta.HaeTilauksenRivit(0);

            decimal odotettu = 250;
            decimal tulos = rajapinta.LaskeTilauksenSumma(rivit);

            Assert.AreEqual(odotettu, tulos);
        }
    }
}

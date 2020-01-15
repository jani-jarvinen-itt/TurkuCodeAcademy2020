using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp11.Logiikka;
using WindowsFormsApp11.Models;

namespace WinFormsApp11.Tests.Mock
{
    public class TilauksenSummaMock : ITilauksenSumma
    {
        public List<Order_Details> HaeTilauksenRivit(int tilausNro)
        {
            List<Order_Details> rivit = new List<Order_Details>()
            {
                new Order_Details()
                {
                    UnitPrice = 10,
                    Quantity = 5
                },
                new Order_Details()
                {
                    UnitPrice = 20,
                    Quantity = 10
                }
            };

            return rivit;
        }

        public decimal LaskeTilauksenSumma(List<Order_Details> rivit)
        {
            TilauksenSumma laskenta = new TilauksenSumma();
            decimal summa = laskenta.LaskeTilauksenSumma(rivit);
            return summa;
        }
    }
}

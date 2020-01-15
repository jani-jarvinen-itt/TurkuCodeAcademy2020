using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp11.Models;

namespace WindowsFormsApp11.Logiikka
{
    public class TilauksenSumma : ITilauksenSumma
    {
        public List<Order_Details> HaeTilauksenRivit(int tilausNro)
        {
            throw new NotImplementedException();
        }

        public decimal LaskeTilauksenSumma(int tilausNro)
        {
            NorthwindEntities entities = new NorthwindEntities();

            decimal sum = (from od in entities.Order_Details
                           where od.OrderID == tilausNro
                           select od).Sum(
                od => od.UnitPrice * od.Quantity);

            return sum;
        }
    }
}

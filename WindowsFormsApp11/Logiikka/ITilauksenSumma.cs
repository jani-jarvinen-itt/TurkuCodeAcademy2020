using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp11.Models;

namespace WindowsFormsApp11.Logiikka
{
    interface ITilauksenSumma
    {
        List<Order_Details> HaeTilauksenRivit(int tilausNro);

        decimal LaskeTilauksenSumma(int tilausNro);
    }
}

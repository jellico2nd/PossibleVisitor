using FurtherCodeTests.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurtherCodeTests.Models.ConcreteClasses
{
    public class TotalFromList : ITotalFromList
    {
        public TotalFromList()
        {

        }
        public void GetTotalPrice(IList<decimal> prices, StringBuilder result)
        {
            decimal total = 0.0m;
            foreach (var item in prices)
            {
                total += item;
            }
            result.Append($"Total    {total.ToString("c")}\r\n");
        }
    }
}

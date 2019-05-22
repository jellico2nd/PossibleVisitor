using System;
using System.Collections.Generic;
using System.Text;

namespace FurtherCodeTests.Models.Interfaces
{
    public interface ITotalFromList
    {
        void GetTotalPrice(IList<decimal> prices, StringBuilder result);
    }
}

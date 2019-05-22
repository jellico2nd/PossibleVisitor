using FurtherCodeTests.Models.ConcreteClasses;
using FurtherCodeTests.Models.Interfaces;
using System;
using Xunit;

namespace TestsForShoppingBasket
{
    public class UnitTest1
    {
        [Fact]
        public void GivenShoppingBasket_TheSummaryWithTotal_HasCorrectValues()
        {
            IShopingBasket basket = new ShoppingBasket();

            var Summary = "Item1    £12.50\r\n" +
                          "Item2     £2.50\r\n" +
                          "Item3     £1.50\r\n" +
                          "--------------\r\n" +
                          "Total    £16.50\r\n";
            Assert.Equal("", Summary);
        }
    }
}

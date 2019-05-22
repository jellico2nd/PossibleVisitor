using FurtherCodeTests.Models.Abstracts;
using FurtherCodeTests.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurtherCodeTests.Models.ConcreteClasses
{
    public class ShoppingBasket : IShopingBasket, IVisitor
    {
        private IList<ShoppingItemClass> shoppingItems;
        private IList<decimal> Total;
        private StringBuilder Summary;
        private ITotalFromList TotalFromList;

        public ShoppingBasket()
        {
            shoppingItems = new List<ShoppingItemClass>();
            Summary = new StringBuilder();
            Total = new List<decimal>();
            TotalFromList = new TotalFromList();
        }

        public void PrintSummary(StringBuilder result)
        {
            foreach (var item in shoppingItems)
            {
                item.Print(Summary);
                item.GetPrice(Total);
            }
            Summary.Append("--------------\r\n");

            TotalFromList.GetTotalPrice(Total, Summary);

            result.Append(Summary);
        }

        public void Visit(ShoppingItem item)
        {
            shoppingItems.Add(item as ShoppingItemClass);
        }
    }
}

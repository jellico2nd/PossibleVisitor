using FurtherCodeTests.Models.Abstracts;
using FurtherCodeTests.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurtherCodeTests.Models.ConcreteClasses
{
    public class ShoppingItemClass : ShoppingItem
    {
        private decimal Price;
        private string Name;

        public ShoppingItemClass(string name, decimal price = 0.0m)
        {
            Name = name;
            Price = price;
        }

        public void Print(StringBuilder stringBuilder)
        {
            stringBuilder.Append($"{Name}   {Price.ToString("c")}\r\n");
        }

        public void GetPrice(IList<decimal> prices)
        {
            prices.Add(Price);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

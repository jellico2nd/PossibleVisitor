using FurtherCodeTests.Models.ConcreteClasses;
using System;
using System.Text;

namespace FurtherCodeTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var test1 = new ShoppingItemClass("Item1", 12.5m);
            var test2 = new ShoppingItemClass("Item2", 2.5m);
            StringBuilder sb = new StringBuilder();

            var shoppingBasket = new ShoppingBasket();
            shoppingBasket.Visit(test1);
            shoppingBasket.Visit(test2);
            shoppingBasket.PrintSummary(sb);
            Console.WriteLine(sb.ToString());
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

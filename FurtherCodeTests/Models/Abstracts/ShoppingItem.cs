using FurtherCodeTests.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurtherCodeTests.Models.Abstracts
{
    public abstract class ShoppingItem
    {
        public abstract void Accept(IVisitor visitor);
    }
}

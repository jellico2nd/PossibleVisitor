using FurtherCodeTests.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurtherCodeTests.Models.Interfaces
{
    public interface IVisitor
    {
        void Visit(ShoppingItem item);
    }
}

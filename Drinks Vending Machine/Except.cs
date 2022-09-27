using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_Vending_Machine
{
    /// <summary>
    /// <br>The ingredients are out of stock Exception.</br>
    /// <para>The class have 2 constructors:
    /// one is empty, the second is need to get <see cref="string"/>.</para>
    /// </summary>
    internal class IngredientsOutOfStockException : Exception
    {
        public IngredientsOutOfStockException() { }
        public IngredientsOutOfStockException(string message) : base(message) { }
    }
}

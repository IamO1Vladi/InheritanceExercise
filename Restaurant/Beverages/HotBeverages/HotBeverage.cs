using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverages.HotBeverages
{
    internal class HotBeverage : Beverage
    {
        public HotBeverage(string name, decimal price, double milimiters) : base(name, price, milimiters)
        {
        }
    }
}

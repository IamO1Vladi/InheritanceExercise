using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverages.HotBeverages
{
    internal class Coffee : HotBeverage
    {
        public Coffee(string name, double caffeine) : base(name, CoffeePrice, CoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        private const double  CoffeeMilliliters = 50;

        private const decimal CoffeePrice = 3.50m;

        private double caffeine;

        public double Caffeine { get => caffeine; set => caffeine = value; }

       

    }
}

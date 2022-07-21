using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverages
{
    internal class Beverage : Product
    {
        public Beverage(string name, decimal price,double milimiters) : base(name, price)
        {
            Milliliters = milimiters;
        }


        private double milliliters;

        public double Milliliters { get => milliliters; set => milliliters = value; }
       

    }
}

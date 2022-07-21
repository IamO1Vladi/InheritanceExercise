using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Food.MainDish
{
    internal class Fish : MainDish
    {
        private const double Grams = 22;
        public Fish(string name, decimal price) : base(name, price, Grams)
        {
        }
    }
}

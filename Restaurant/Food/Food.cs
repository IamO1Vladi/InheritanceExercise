using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Food
{
    internal class Food : Product
    {
        public Food(string name, decimal price,double grams) : base(name, price)
        {
            this.Grams = grams;
        
        }
            private double grams;

        public double Grams { get => grams; set => grams = value; }


        

    
    }
}

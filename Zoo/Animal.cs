using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Animal
    {

        private string name;

        public Animal(string name)
        {
            Name = name;
        }

        protected string Name { get => name; set => name = value; }
    }
}

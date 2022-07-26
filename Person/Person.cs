﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {

        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        protected string Name { get => name; set => name = value; }
        protected int Age { get => age; set => age = value; }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();
        }


    }
}

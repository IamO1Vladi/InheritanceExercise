using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            Fuel = fuel;
            HorsePower = horsePower;
            
        }

        private const double DefaultFuelConsumption = 1.25;
        virtual public double FuelConsumption => DefaultFuelConsumption;

        public double Fuel { get => fuel; set => fuel = value; }
        public int HorsePower { get => horsePower; set => horsePower = value; }

        private double fuel;
        private int horsePower;


        virtual public void Drive(double kilometers)
        {
            this.Fuel -= kilometers * FuelConsumption;
        }
    }
    
    
    


    





}

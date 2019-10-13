using System;
using AreaLib.Interfaces;

namespace AreaLib.Models{
    public class Round : IAreaCalculation
    {
        public double Radius { get; private set; }
        public Round(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea => Math.PI * Math.Pow(Radius,2);
    }
}
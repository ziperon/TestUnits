using System;
using AreaLib.Interfaces;

namespace AreaLib
{
    public class CalculatorArea
    {
        public IAreaCalculation CalculateObject { get; set; }
        
        public CalculatorArea(IAreaCalculation obj)
        {
            CalculateObject = obj;
        }
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area => CalculateObject?.CalculateArea ?? 0;

    }
}

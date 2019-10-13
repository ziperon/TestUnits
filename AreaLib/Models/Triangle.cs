using System;
using System.Linq;
using AreaLib.Interfaces;

namespace AreaLib.Models {
    public class Triangle :  IAreaCalculation
    {
        public Triangle(double sideA,double sideB,double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            // Простой способ определения катетов
            IOrderedEnumerable<double> array     = new double[] { sideA, sideB, sideC }.OrderBy(_=>_);
            // Определяем является ли треугольник прямоугольным
            RightTriangle = Math.Pow(array.FirstOrDefault(),2)+Math.Pow(array.Skip(1).FirstOrDefault(),2)==Math.Pow(array.LastOrDefault(),2);
            p = (SideA+SideB+SideC)/2;
        }

        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        private double p { get; set; }
        ///<summary>
        /// Флаг для прямоугольного треугольника
        ///</summary>
        public bool RightTriangle { get; private set; } 

        ///<summary>
        /// Пллощадь треугольника
        ///</summary>
        public double CalculateArea => Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
}
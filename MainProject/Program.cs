using System;
using AreaLib;
using AreaLib.Models;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
			var triangle = new Triangle(12, 21, 10);
            var calculatorOfTriangle = new CalculatorArea(triangle);

            Console.WriteLine($"Triangle area: {calculatorOfTriangle.Area}");
			Console.WriteLine($"Triangle right: {triangle.RightTriangle}");

            var calculatorOfRound = new CalculatorArea(new Round(11));
            
            Console.WriteLine($"Round area: {calculatorOfRound.Area}");

            Console.Read();
        }
    }
}

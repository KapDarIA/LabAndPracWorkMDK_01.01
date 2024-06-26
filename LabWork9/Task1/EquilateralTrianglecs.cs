using System;
using System.Drawing;
using System.Security.Principal;

namespace Task1
{
    internal class EquilateralTrianglecs : IFigure
    {
        public double Side { get; set; }

        public string NameOfFigure { get; set; } = "Равносторонний треугольник";

        public EquilateralTrianglecs (double side)
        {
            Side = side;
        }

        public double GetSquareOfFigure() => Math.Round(((Side * Side) * Math.Sqrt(3)) / 4, 2);

        public double GetPerimetеr() => Side * 3;

        public void PrintInformation()
        {
            Console.WriteLine($"Название фигуры:{NameOfFigure}\nПлощадь фигуры:{GetSquareOfFigure()}\nПериметр фигуры:{GetPerimetеr()}");
        }
    }
}

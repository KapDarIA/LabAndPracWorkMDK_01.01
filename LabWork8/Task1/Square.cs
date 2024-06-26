using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Square : Figure
    {

        public int Side1 { get; set; } = 5;
        public int Side2 { get; set; } = 7;

        public override string NameOfFigure => "Прямоугольник";

        public override string GetInformationOfFigure() => ($"Название фигуры:{NameOfFigure}\nПлощадь фигуры:{GetSquareOfFigure()}\nПериметр фигуры:{GetPerimetеr()}");

        public override int GetPerimetеr() => (Side1 + Side2) * 2;

        public override int GetSquareOfFigure() => Side1 * Side2;
    }
}

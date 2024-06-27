using System.Drawing;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ring ring = new Ring();
            GetFigure(ring);

            Circle circle = new Circle();
            GetFigure(circle);

            Square square = new Square();
            GetFigure(square);
        }

        static void GetFigure(FigureSquare figureType)
        {
            if (figureType is Circle circle)
            {
                Console.WriteLine($"Площадь круга:{circle.GetSquare()}\n");
            }
            if (figureType is Square square)
            {
                Console.WriteLine($"Площадь прямоугольника:{square.GetSquare()}\n");
            }
            if (figureType is Ring ring)
            {
                Console.WriteLine($"Площадь кольца:{ring.GetSquare()}\n"); ;
            }

        }
    }
}

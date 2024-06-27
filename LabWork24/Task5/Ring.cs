using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Ring : FigureSquare
    {
        public double R {  get; set; }
        public double r { get; set; }
        public override double GetSquare()
        {
            Console.Write("Введите внешний радиус:");
            R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите внутренний радиус:");
            r = Convert.ToDouble(Console.ReadLine());

            return GetCircleSquare(R)-GetCircleSquare(r);
        }
    }
}

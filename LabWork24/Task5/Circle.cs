using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Circle : FigureSquare
    {
        public double R {  get; set; }
        public override double GetSquare()
        {
            Console.Write("Введите радиус:");
            R = Convert.ToDouble(Console.ReadLine());

            return GetCircleSquare(R);
        }
    }
}

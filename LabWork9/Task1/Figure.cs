namespace Task1
{
    internal class Figure : IPrinter, IFigure
    {
        public double side;
        public string name;

        public double Side { get => side; set => side = value; }
        public string Name { get => name; set => name = value; }

        public string GetName
        {
            get => Name; set => Name = value;
        }

        public Figure() : this(4, "Равностороний треугольник") { }

        public Figure(double side, string name)
        {
            Side = side;
            Name = name;
        }

        public void GetArea()
        {
            Console.WriteLine($"Площадь фигуры: {(Math.Sqrt(3) * side * side) / 4}");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Название фигуры: {name}\nДлина стороны: {side}");
        }

        public void GetPerimeter()
        {
            Console.WriteLine($"Периметр фигуры: {side * 3}");
        }
        public void Print() => Console.WriteLine($"Фигура:{name}\nСтрорна фигуры:{side}");
    }
}

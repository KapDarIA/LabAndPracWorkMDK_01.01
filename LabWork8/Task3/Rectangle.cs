namespace Task3
{
    internal class Rectangle : Figure
    {

        public double length;
        public double width;
        public string name;

        public override string GetName { get; set; }

        public override void GetArea()
        {
            Console.WriteLine($"Площадь фигуры: {length * width}");
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Название фигуры: {GetName}\nДлина фигуры: {length}\nШирина фигуры: {width}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"Периметр фигуры: {(length * width) * 2}");
        }

        public Rectangle() : this(6, 8, "Прямоугольник", "") { }

        public Rectangle(double lenght, double width, string name, string getName)
        {
            length = lenght;
            this.width = width;
            GetName = name;
        }
    }
}

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Явный вызов");
            AirFlight airFlight1 = new AirFlight();
            Console.WriteLine(airFlight1.ToString());
            Console.WriteLine();
            Console.WriteLine("Неявный вызов");
            Console.WriteLine(airFlight1);

            Console.WriteLine();

            Console.WriteLine("Сравнение двух объектов");
            AirFlight airFlight2 = new AirFlight("Москва", 1, 20);
            airFlight1.Print();

            Console.WriteLine();

            airFlight2.Print();
            if (airFlight1.Equals(airFlight2)) Console.WriteLine("Объекты равны");
            else Console.WriteLine("Объекты неравны");

            Console.WriteLine();

            Console.WriteLine("Строка из случайных символов");
            ExpandClass expandClass = new ExpandClass();
            Console.WriteLine(ExpandClass.GetString(6));

            Console.WriteLine();

            Console.WriteLine("Информация о фигуре");
            Square square = new Square();
            square.Side1 = 10;
            square.Side2 = 20;
            Console.WriteLine(square.GetInformationOfFigure());

        }
    }
}

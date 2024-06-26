namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Изначальные данные");
            AirFlight airFlight1 = new AirFlight("Архангельск", 1, 20);
            airFlight1.Print();
            Console.WriteLine();
            Console.WriteLine("Значения после оператора ++");
            airFlight1++;
            airFlight1.Print();

            Console.WriteLine();

            Console.WriteLine("Изначальные данные");
            AirFlight airFlight2 = new AirFlight("Москва", 1, -110);
            airFlight2.Print();
            Console.WriteLine();
            Console.WriteLine("Значения после оператора ++");
            airFlight2++;
            airFlight2.Print();

            Console.WriteLine();

            Console.WriteLine("Бинарный оператор +");
            AirFlight airFlight3 = airFlight1 + airFlight2;
            airFlight3.Print();

            Console.WriteLine();

            Console.WriteLine("Оператор сравнения ==");
            Console.WriteLine(airFlight1 == airFlight2);

            Console.WriteLine();

            Console.WriteLine("Оператор сравнения !=");
            Console.WriteLine(airFlight1 != airFlight2);

            Console.WriteLine();

            Console.WriteLine("Унарный оператор true/false");
            AirFlight airFlight4 = new AirFlight();
            if (airFlight4) Console.WriteLine("true"); else Console.WriteLine("false");

        }
    }
}

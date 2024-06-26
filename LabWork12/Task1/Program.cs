namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirFlight airFlight1 = new AirFlight("Архангельск", 1, 100);
            AirFlight airFlight2 = new AirFlight("Абу-Даби", 2, 250);
            AirFlight airFlight3 = new AirFlight("Северодвинск", 3, 105);
            AirFlight airFlight4 = new AirFlight("Санкт-Петербург", 4, 1000);

            airFlight1.Print();

            Console.WriteLine();

            airFlight1.Number = 5;
            airFlight1.Destination = "Новочеркаск";
            airFlight1.Type = Type.Iterior;
            airFlight1.Print();
            airFlight3.Type= Type.Iterior;

            Console.WriteLine("Какой тип рейса вам нужен\n1.Международный  2.Внутрений");
            string findType = Console.ReadLine();

            AirFlight[] flights = new AirFlight[] { airFlight1, airFlight2,airFlight3,airFlight4 };
            for (int i = 0; i < flights.Length; i++) 
            {
                if(findType == Type.Iterior)
            }
        }
    }
}

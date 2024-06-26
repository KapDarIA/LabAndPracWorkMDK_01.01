namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AirFlight airFlight1 = new AirFlight();
                AirFlight airFlight2 = new AirFlight("Москва", 2, 600);
                AirFlight airFlight3 = new AirFlight("Питер", 3, 50);

                Console.WriteLine(airFlight1.CompareTo(airFlight2));
                Console.WriteLine(airFlight1.CompareTo(airFlight3)); 
                Console.WriteLine(airFlight1.Equals(airFlight2));

                Console.WriteLine();
                

                AirFlight[] arrayAirFlights = { airFlight1, airFlight2, airFlight3 };
                Console.WriteLine("Изначальный массив:");
                for (int i = 0; i < arrayAirFlights.Length; i++) { arrayAirFlights[i].Print(); Console.WriteLine(); }

                Array.Sort(arrayAirFlights);
                Array.Sort(arrayAirFlights);

                Console.WriteLine("Измененный массив:");
                for (int i = 0; i < arrayAirFlights.Length; i++) { arrayAirFlights[i].Print(); Console.WriteLine(); }
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}

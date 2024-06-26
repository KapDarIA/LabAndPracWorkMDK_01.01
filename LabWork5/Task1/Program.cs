namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Конструктор по умолчанию
            AirFlight airFlight = new AirFlight(); 
            airFlight.Print();

            Console.WriteLine();

            airFlight.Destination = "";
            airFlight.FlightNumber = 7;
            airFlight.Capacity = 100;
            airFlight.Print();

            Console.WriteLine();

            // Конструктор с параметрами 
            AirFlight airFlight2 = new AirFlight("Нью-Йорк", 1, 50);
            airFlight2.Print();

            Console.WriteLine();

            airFlight2.Destination = "Сахалин";
            airFlight2.Capacity = 200;
            airFlight2.FlightNumber = 10;
            airFlight2.Print();

            Console.WriteLine();

            Console.WriteLine("Введите количество авиарейсов:");

            int numberAirFlights = Convert.ToInt32(Console.ReadLine());

            AirFlight[] airFlightListArray = new AirFlight[numberAirFlights];

            string destination;
            int flightNumber, capacity;

            Console.WriteLine();

            for (int i = 0; i < airFlightListArray.Length; i++)
            {
                Console.WriteLine("Введите пункт назначения:");
                destination = Console.ReadLine();

                Console.WriteLine("Введите номер рейса:");
                flightNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите вместимость:");
                capacity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                airFlightListArray[i] = new AirFlight(destination, flightNumber, capacity);
            }

            for (int i = 0; i < airFlightListArray.Length; i++)
            {
                Console.WriteLine($"Авиарейс №{i+1}:");
                airFlightListArray[i].Print();

                Console.WriteLine();
            }

            //Вывод рейсов до заданного пункта назначения

            Console.WriteLine("Введите нужный пункт назначения:");

            destination = Console.ReadLine();
            int errorCounter= 0;


            for (int i = 0; i < airFlightListArray.Length; i++)
            {
                if (destination == airFlightListArray[i].Destination)
                {
                    airFlightListArray[i].Print();
                }
                else
                {
                    errorCounter++;
                }
            }

            if (errorCounter == airFlightListArray.Length)
            {
                Console.WriteLine("Нет результатов поиска");
            }

            Console.WriteLine("Введите нужную вместимость:");
            capacity = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < airFlightListArray.Length; i++)
            {
                if (capacity < airFlightListArray[i].Capacity)
                {
                    airFlightListArray[i].Print();
                }
                else
                {
                    errorCounter++;
                }
            }

            if (errorCounter == airFlightListArray.Length)
            {
                Console.WriteLine("Нет результатов поиска");
            }
        }
    }
}

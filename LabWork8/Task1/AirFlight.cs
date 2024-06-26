namespace Task1
{
    internal class AirFlight (string destination, int flightNumber, int capacity)
    {
        public string Destination {  get; set; } = destination;
        public int FlightNumber { get; set; } = flightNumber;
        public int Capacity {  get; set; } = capacity;

        public AirFlight() : this ("Москва", 1, 20) {}

        public override string ToString() => ($"Пункт назначения:{Destination}\nНомер рейса:{FlightNumber}\nВместимость:{Capacity}");

        public override bool Equals(object? obj)
        {
            if (obj is AirFlight airFlight)
                return Destination == airFlight.Destination && FlightNumber == airFlight.FlightNumber && Capacity == airFlight.Capacity;
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine($"Пункт назначения:{Destination}\nНомер рейса:{FlightNumber}\nВместимость:{Capacity}");
        }
    }
}

namespace Task1
{
    internal class AirFlight : IComparable, IComparable<AirFlight>, IEquatable<AirFlight>
    {
        public string Destination {  get; }
        public int FlightNumber { get; set;  }
        public int Capacity { get; set; }

        public AirFlight() : this("Архангельск", 1, 100) { }

        public AirFlight(string destination, int flightNumber, int capacity)
        {
            Destination = destination;
            FlightNumber = flightNumber;
            Capacity = capacity;
        }
        public void Print()
        {
            Console.WriteLine($"Пункт назначения:{Destination}\nНомер рейса:{FlightNumber}\nВместимость:{Capacity}");
        }
        public int CompareTo(object? obj)
        {
            if (obj is AirFlight airFlight) { return Capacity.CompareTo(airFlight.Capacity); }
            throw new NotImplementedException("Нет реализации");
        }
        public int CompareTo(AirFlight? airFlight)
        {
            if (airFlight is not null) { return Capacity.CompareTo(airFlight.Capacity); }
            throw new NotImplementedException("Нет реализации");
        }

        public bool Equals(AirFlight? obj)
        {
            if (obj is AirFlight airFlight) { return Destination == airFlight.Destination && FlightNumber == airFlight.FlightNumber && Capacity == airFlight.Capacity; }
            throw new NotImplementedException("Нет реализации");
        }
    }

}

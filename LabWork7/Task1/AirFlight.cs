namespace Task1
{
    internal class AirFlight
    {
        private string _destination { get; set; }
        private int _flightNumber { get; set; }
        private int _capacity { get; set; }

        public AirFlight() : this("Москва", 1, -100) {}

        public AirFlight(string destination, int flightNumber, int capacity)
        {
            _destination = destination;
            _flightNumber = flightNumber;
            _capacity = capacity;
        }

        public static AirFlight operator ++(AirFlight airFlight) => new AirFlight{_destination= airFlight._destination, _flightNumber = airFlight._flightNumber, _capacity = airFlight._capacity + 1};

        public static AirFlight operator +(AirFlight a, AirFlight b) => new AirFlight{_destination = a._destination, _flightNumber = a._flightNumber, _capacity= a._capacity + b._capacity};

        public static bool operator ==(AirFlight a, AirFlight b) => a._capacity == b._capacity && a._destination == b._destination && a._flightNumber == b._flightNumber;

        public static bool operator !=(AirFlight a, AirFlight b) => a._capacity != b._capacity || a._destination != b._destination || a._flightNumber != b._flightNumber;

        public static bool operator true(AirFlight airFlight) => airFlight._capacity >= 0;

        public static bool operator false(AirFlight airFlight) => airFlight._capacity < 0;

        public void Print()
        {
            Console.WriteLine($"Пункт назначения: {_destination}\nНомер рейса:{_flightNumber}\nВместимость:{_capacity}");
        }
    }
}

namespace Task1
{
    internal class AirFlight
    {
        private string _destination;
        private int _flightNumber;
        private int _capacity;

        public AirFlight() : this("Архангельск", 20, 200)
        {
        }

        public AirFlight(string destination, int flightNumber, int capacity)
        {
            _destination = destination;
            _flightNumber = flightNumber;
            _capacity = capacity;
        }

        public object? this[string index]
        {
            get
            {
                return index switch
                {
                    "Пункт назначения" => _destination,
                    "Номер рейса" => _flightNumber,
                    "Вместимость" => _capacity,
                    _ => null
                };
            }
        }

        public char this[int index] => index < 0 || index >= _destination.Length ? '\0' : _destination[index];

        public void Print()
        {
            Console.WriteLine($"Пункт назначения: {_destination}\nНомер рейса: {_flightNumber}\nВместимость: {_capacity}\n");
        }
    }
}


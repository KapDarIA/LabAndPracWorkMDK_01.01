namespace Task1
{
    internal struct AirFlight
    {
        private string _destination;
        private int _number;
        private int _capacity;
        public Type Type;

        public string Destination
        {
            get => _destination;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _destination = value;
                }
            }
        }

        public int Number
        {
            get => _number;
            set
            {
                if (value >= 0)
                {
                    _number = value;
                }
            }
        }

        public int Capacity
        {
            get => _capacity;
            set
            {
                if (value >= 0)
                {
                    _capacity = value;
                }
            }
        }

        public AirFlight(string destination, int number, int capacity)
        {
            Destination = destination;
            Number = number;
            Capacity = capacity;
            Type = Type.International;
        }


        public void Print()
        {
            Console.WriteLine($"Пункт назначения:{Destination}\nНомер рейса:{Number}\nВместимость:{Capacity}\nТип полета:{Type}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class AirFlight
    {
        private string _destination;
        private int _flightNumber;
        private int _capacity;

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

        public int FlightNumber
        {
            get => _flightNumber;

            set 
            {
                if (value >= 0)
                {
                    _flightNumber = value;
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

        public AirFlight() 
        {
            _destination = "Архангельск";
            _flightNumber = 0;
            _capacity = 0;
        }

        public AirFlight(string destination, int flightNumber, int capacity)
        {
            _destination = destination;
            _flightNumber = flightNumber;
            _capacity = capacity;
        }

        public void Print()
        {
            Console.WriteLine($"Пункт назначения: {_destination},\n" +
                $"Номер рейса:{_flightNumber},\nВместимость:{_capacity}");
        }
    }
}

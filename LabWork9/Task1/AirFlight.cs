using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class AirFlight : IPrinter
    {
        public string Destination {  get; set; }
        public int FlightNumber {  get; set; } 
        public int Capacity { get; set; } 

        public AirFlight() : this ("Архангельск", 1, 100) { }

        public AirFlight (string destination, int flightNumber, int capacity)
        {
            Destination = destination;
            FlightNumber = flightNumber;
            Capacity = capacity;
        }

        public void Print()
        {
            Console.WriteLine($"Пункт назначения:{Destination}\nНомер рейса:{FlightNumber}\nВместимость:{Capacity}");
        }
    }
}

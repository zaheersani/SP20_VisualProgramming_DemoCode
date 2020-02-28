using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Runner
    {
        public Runner()
        {
            Flight flight = new Flight(1, 10);
            Console.WriteLine(flight.Seats.Count());
        }
    }

    public class Flight
    {
        public int FlightID { get; set; }

        public int SeatingCapacity { get; set; }

        public Seat[] Seats { get; private set; }

        public Flight()
        {

        }
        public Flight(int id, int capacity)
        {
            this.FlightID = id;
            this.SeatingCapacity = capacity;
            this.Seats = new Seat[capacity];
        }

    }
    public class Seat
    {
        public int SeatNo { get; set; }
    }
}

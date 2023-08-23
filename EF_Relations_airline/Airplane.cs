using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Relations_airline
{
    public class Airplane
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int MaxPassengers { get; set; }
        public int CountryId { get; set; }
        public Country? Country { get; set; }
        public List<Flight> Flights { get; set; } = new();
    }
}

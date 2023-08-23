using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Relations_airline
{
    public class Flight
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string DeparturePlace { get; set; }
        public string ArrivalPlace { get; set; }
        public int AirplaneId { get; set; }
        public Airplane? Airplane { get; set; }
        public List<Client> Clients { get; set; } = new();

    }
}

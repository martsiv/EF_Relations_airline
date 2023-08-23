using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Relations_airline
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int GenderId { get; set; }
        public int AccountId { get; set; }
        public Gender? Gender { get; set; }
        public Account? Account { get; set; }
        public List<Flight> Flights { get; set; } = new();

    }
}

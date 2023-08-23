using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Relations_airline
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Airplane> Airplanes { get; set; } = new();
    }
}

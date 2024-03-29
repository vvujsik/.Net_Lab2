using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Api
{
    internal class PogodaDB
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string wejscie { get; set; }
        public required float Temp {  get; set; }
        public required float Lat { get; set; }
        public required float Lon { get; set; }
        public required string Country { get; set; }
        public override string ToString()
        {
            return $"Id:{Id},\tName:{Name},\tCountry:{Country},\tTemp{Temp - 273.15:0.00}";
        }
    }
}

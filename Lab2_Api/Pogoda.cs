using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Api
{
    internal class Pogoda
    {
        public string name { get; set; }
        public main_temps main { get; set; }
        public kordy coord { get; set; }
        public info sys { get; set; }
        public int cod { get; set; }

        public override string ToString()
        {
            return $"{name}:   Temp:{main.temp:0.00}   Odczuwalna:{main.feels_like:0.00}";
        }
    }

    internal class main_temps
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
        public void przelicz()
        {
            this.temp = this.temp - (float)273.15;
            this.feels_like = this.feels_like - (float)273.15;
        }
    }
    internal class kordy
    {
        public float lat { get; set; }
        public float lon { get; set; }
    }
    internal class info
    {
        public string country { get; set; }
    }
}

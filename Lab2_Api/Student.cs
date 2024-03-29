using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Api
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Average {  get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\tName:{Name}\tAverage: {Average:0.00}";

        }
    }
}

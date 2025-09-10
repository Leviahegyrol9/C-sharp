using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Városok
{
    public class City
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public string Country2 { get; set; }
        public string Area { get; set; }
        public int Population { get; set; }
        public double Place { get; set; }
        public City()
        {
            
        }

        public override string ToString()
        {
            return $"{Name};{Type};{Country};{Country2};{Area};{Population};{Place}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    public class Animal
    {
        public string Name { get; set; }
        public string LatinName { get; set; }
        public string Continent { get; set; }
        public string Food { get; set; }

        public Animal()
        {
            
        }
        public Animal(string name, string latinName, string continent, string food)
        {
            Name = name;
            LatinName = latinName;
            Continent = continent;
            Food = food;
        }

        public override string ToString()
        {
            return $"{Name},{LatinName},{Continent},{Food}";
        }
    }
}

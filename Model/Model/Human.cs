using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Birth()
        {
            return DateTime.Now.Year - Age;
        }

        public override string ToString()
        {
            return $"{Name}({Age})";
        }
    }
}

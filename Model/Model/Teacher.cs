using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Teacher : Human
    {
        public int Salary { get; set; }
        public string Vocation { get; set; }

        public Teacher(string name, int age, int salary, string vocation) : base(name, age)
        {
            Salary = salary;
            Vocation = vocation;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {Vocation} szakos tanár: {Salary}";
        }
    }
}

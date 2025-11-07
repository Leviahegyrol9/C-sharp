using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Student:Human
    {
        public double Average {  get; set; }
        public int Class {  get; set; }

        public Student(string name, int age, double average, int _class) : base(name, age)
        {
            Average = average;
            Class = _class;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {Class} --> {Average}";
        }
    }
}

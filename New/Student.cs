using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    public class Student
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Class { get; set; }

        public Student()
        {
            
        }

        public override string ToString()
        {
            return $"{Name}; {Sex}; {Class}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    public class Nobel
    {
        public int Year { get; set; }
        public string Type { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Nobel()
        {
            
        }
        public override string ToString()
        {
            return $"{Year};{Type};{LastName};{FirstName}";
        }
    }
}

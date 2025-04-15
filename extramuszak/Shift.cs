using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extramuszak
{
    public class Shift
    {
        public string Name { get; set; }
        public string Day { get; set; }
        public string Path { get; set; }
        public Shift()
        {
            
        }
        public override string ToString()
        {
            return $"{Name}\t{Day}\t{Path}";
        }
    }
}

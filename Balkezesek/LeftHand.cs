using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    public class LeftHand
    {
        public string Name { get; set; }
        public DateTime First { get; set; }
        public DateTime Last { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public LeftHand(string name, DateTime first, DateTime last, int weight, int height)
        {
            Name = name;
            First = first;
            Last = last;
            Weight = weight;
            Height = height;
        }
    }
}

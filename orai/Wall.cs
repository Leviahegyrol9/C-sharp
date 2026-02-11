using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai
{
    public class Wall
    {
        public string Id { get; set; }
        public int WallT { get; set; }
        public int BaseT { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }

        public Wall()
        {
            
        }

        public override string ToString()
        {
            return $"{Id}\t{WallT}\t{BaseT}\t{Color}\t{Type}";
        }
    }
}

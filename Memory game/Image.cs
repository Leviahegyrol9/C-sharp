using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_game
{
    public class Image
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public Image()
        {
            
        }
        public Image(string name, string path)
        {
            Name = name;
            Path = path;
        }
        public override string ToString()
        {
            return $"{Name}; {Path}";
        }
    }
}

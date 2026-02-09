using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel_díj
{
    public class Nobel
    {
        public int evszam {  get; set; }
        public string tipus {  get; set; }
        public string keresztnev {  get; set; }
        public string vezeteknev {  get; set; }

        public override string ToString()
        {
            return $"{evszam};{tipus};{keresztnev};{vezeteknev}";
        }
    }
}

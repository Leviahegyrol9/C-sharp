using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Dolgozo
    {
        public string nev {  get; set; }
        public string azonosito {  get; set; }
        public int ber {  get; set; }

        public Dolgozo(string nev, string azonosito, int ber)
        {
            this.nev = nev;
            this.azonosito = azonosito;
            this.ber = ber;
        }
        public virtual void KiirInformacio()
        {
            Console.WriteLine(nev+" ,"+azonosito+", "+ber+" Ft");
        }
    }
}

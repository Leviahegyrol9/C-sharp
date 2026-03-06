using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Ceg
    {
        public string nev {  get; set; }
        public int alkamazottszam {  get; set; }
        public int bevetel {  get; set; }

        public Ceg(string nev, int alkamazottszam, int bevetel)
        {
            this.nev = nev;
            this.alkamazottszam = alkamazottszam;
            this.bevetel = bevetel;
        }
        public virtual int Arany()
        {
            return bevetel / alkamazottszam;
        }

        public override string ToString()
        {
            return "Egy alkalmazotttra juto bevetel:"+ Arany().ToString("f2");
        }
    }
}

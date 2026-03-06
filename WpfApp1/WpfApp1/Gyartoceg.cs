using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Gyartoceg:Ceg
    {
        

        public int termekszam {  get; set; }
        public int gyarszam {  get; set; }

        public Gyartoceg(string nev, int alkamazottszam, int bevetel,int termekszam,int gyarszam) : base(nev, alkamazottszam, bevetel)
        {
            this.termekszam = termekszam;
            this.gyarszam = gyarszam;
        }

        public override int Arany()
        {
            return termekszam / gyarszam;
        }

        public override string ToString()
        {
            return "Egy alkalmazotttra juto bevetel:" + Arany().ToString("f2");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Kereskedelmiceg:Ceg
    {
      

        public int uzletszam {  get; set; }
        public int vevoszam {  get; set; }

        public Kereskedelmiceg(string nev, int alkamazottszam, int bevetel,int uzletszam,int vevoszam) : base(nev, alkamazottszam, bevetel)
        {
            this.uzletszam = uzletszam;
            this.vevoszam = vevoszam;
        }
        public override int Arany()
        {
            return vevoszam / uzletszam;
        }

        public override string ToString()
        {
            return "Egy üzletre juto vevoszam:" + Arany().ToString("f2");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4.Model
{
    public class Okostelefon : Eszkoz
    {
        public double Jelerosseg { get; set; }
        public Okostelefon(string nev, double suly, int alapTeljesitmeny, double jelerosseg) : base(nev, suly, alapTeljesitmeny)
        {
            Jelerosseg = jelerosseg;
        }
        public override void SulyNovel(int kg)
        {
            base.SulyNovel(kg);
            double hanyszor = kg / 0.1;
            Jelerosseg -= Math.Floor(hanyszor) * 2;

        }

        public void JelErosit(int dbm)
        {
            Jelerosseg += dbm;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, jelerősség: {Jelerosseg} dBm";
        }
    }
}

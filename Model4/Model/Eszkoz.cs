using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4.Model
{
    public class Eszkoz
    {
        public string Nev {  get; set; }
        public double Suly {  get; set; }
        public int AlapTeljesitmeny {  get; set; }
        public Eszkoz(string nev, double suly, int alapTeljesitmeny)
        {
            Nev = nev;
            Suly = suly;
            AlapTeljesitmeny = alapTeljesitmeny;
        }

        public virtual void SulyNovel(int kg)
        {
            Suly += kg;
        }

        public virtual void TeljesitmenyNovel(int watt)
        {
            AlapTeljesitmeny += watt;
        }
        public override string ToString()
        {
            return $"Eszköz: {Nev}, Súly: {Suly} kg, Teljesítmény: {AlapTeljesitmeny} W";
        }
    }
}

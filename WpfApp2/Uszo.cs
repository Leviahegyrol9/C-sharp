using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Uszo : Sportolo
    {


        public string uszasnem { get; set; }
        public int legjobbido { get; set; }

        public Uszo(string nev, int kor, double hetiedzes, string uszasnem, int logjobbido) : base(nev, kor, hetiedzes)
        {
            this.uszasnem = uszasnem;
            this.legjobbido = kor;
        }
        public override double Adatok()
        {
            return legjobbido;
        }
        public override string ToString()
        {
            return nev + " " + uszasnem + " uszasnemben elert legjobb ideje: " + Adatok() + " masodperc";
        }
    }
}
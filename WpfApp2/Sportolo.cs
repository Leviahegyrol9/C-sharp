using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Sportolo
    {
        public string nev { get; set; }
        public int kor { get; set; }
        public double hetiedzes { get; set; }

        public Sportolo(string nev, int kor, double hetiedzes)
        {
            this.nev = nev;
            this.kor = kor;
            this.hetiedzes = hetiedzes;
        }
        public virtual double Adatok()
        {
            return 52 * hetiedzes;
        }

        public override string ToString()
        {
            return nev + " eves edzesszama" + Adatok();
        }
    }
}
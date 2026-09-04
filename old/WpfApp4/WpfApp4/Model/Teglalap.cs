using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Model
{
    public class Teglalap
    {
        public double aoldal;
        public double boldal;
        public double terulet;
        public double kerulet;
        public double atlo;

        public double AOldal
        {
            get { return aoldal; }
            set { aoldal = value; }
        }
        public double BOldal
        {
            get { return boldal; }
            set { boldal = value; }
        }
        public double Terulet
        {
            get
            {
                terulet = (aoldal * boldal);
                return terulet;
            }
        }
        public double Kerulet
        {
            get { 
                kerulet = 2 * (aoldal + boldal);
                return kerulet; 
            }
        }
        public double Atlo
        {
            get {
                atlo = Math.Sqrt(Math.Pow(aoldal, 2) + Math.Pow(atlo, 2));
                return atlo;
            }
        }
    }
}

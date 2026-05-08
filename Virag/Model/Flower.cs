using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virag.Model
{
    public class Flower
    {
        public int tulipan;
        public int rozsa;
        public int narcisz;
        public int fizetendo;

        public int Tulipan
        {
            get { return tulipan; }
            set { tulipan = value; }
        }
        public int Rozsa
        {
            get { return rozsa; }
            set { rozsa = value; }
        }
        public int Narcisz
        {
            get { return narcisz; }
            set { narcisz = value; }
        }
        public int Fizetendo
        {
            get
            {
                fizetendo = 300 * tulipan + 500 * rozsa + 400 * narcisz;
                return fizetendo;
            }
        }

    }
}

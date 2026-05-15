using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vérnyomás.Model
{
    public class Nyomas
    {
        public double kor;
        public double suly;
        public double szint;
        public double pulzus;
        public string vernyomas;

        public double Kor
        {
            get {  return kor; }
            set { kor = value; }
        }
        public double Suly
        {
            get { return suly; }
            set { suly = value; }
        }
        public double Szint
        {
            get { return szint; }
            set { szint = value; }
        }
        public double Pulzus
        {
            get 
            {
                return 220 - kor * 0.7;
            }
        }
        public string Vernyomas
        {
            get
            {
                double bal = 120 + ((kor - 20) / 10) * 2 + ((suly - 70) / 10) * 1.5 + szint * 5;
                double jobb = 80 + ((kor - 20) / 10) * 1.5 + ((suly - 70) / 10) * 1 + szint * 3;
                return $"{Math.Round(bal, 0)}/{Math.Round(jobb)}";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace WpfApp1
{
    public class Konyvek
    {
        public string veznev { get; set; }
        public string kernev { get; set; }
        public DateTime szulido { get; set; }
        public string konyvcim { get; set; }
        public string kod { get; set; }
        public string kiado { get; set; }
        public int kiadaseve { get; set; }
        public int ar { get; set; }
        public string tema { get; set; }
        public int oldalszam { get; set; }
        public int honorarium { get; set; }

        public Konyvek(string sor)
        {
            string[] adatok = sor.Split('\t');
            veznev = adatok[0];
            kernev = adatok[1];
            szulido = DateTime.Parse(adatok[2]);
            konyvcim = adatok[3];
            kod = adatok[4];
            kiado = adatok[5];
            kiadaseve = int.Parse(adatok[6]);
            ar = int.Parse(adatok[7]);
            tema = adatok[8];
            oldalszam = int.Parse(adatok[9]);
            honorarium = int.Parse(adatok[10]);
        }
    }
}

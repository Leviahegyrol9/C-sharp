using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés.Model
{
    public class Allat
    {
        public string Nev {  get; set; }
        public string Faj {  get; set; }
        public int Kor {  get; set; }

        public Allat(string nev, string faj, int kor)
        {
            Nev = nev;
            Faj = faj;
            Kor = kor;
        }

        public virtual void KiirInformacio()
        {
            Console.WriteLine($"{Nev};{Faj};{Kor}");
        }
    }
}

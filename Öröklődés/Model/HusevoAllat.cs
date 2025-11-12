using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés.Model
{
    public class HusevoAllat:Allat
    {
        public string KedvencHus { get; set; }

        public HusevoAllat(string kedvencHus, string nev, string faj, int kor):base(nev, faj, kor)
        {
            KedvencHus = kedvencHus;
        }

        public void Eszik()
        {
            Console.WriteLine($"{Nev} kedvenc eledele a(z) {KedvencHus}.”");
        }

        public override void KiirInformacio()
        {
            base.KiirInformacio();
            Eszik();
        }
    }
}

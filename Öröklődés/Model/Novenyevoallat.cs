using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés.Model
{
    public class Novenyevoallat:Allat
    {
        public string KedvencNoveny { get; set; }

        public Novenyevoallat(string kedvencNoveny, string nev, string faj, int kor) : base(nev, faj, kor)
        {
            KedvencNoveny = kedvencNoveny;
        }

        public void Kiir()
        {
            Console.WriteLine($"Neve: {Nev}; Kedvenc kaja: {KedvencNoveny}");
        }

        public override void KiirInformacio()
        {
            base.KiirInformacio();
            Kiir();
        }
    }
}

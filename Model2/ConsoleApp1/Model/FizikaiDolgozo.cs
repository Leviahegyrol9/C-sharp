using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class FizikaiDolgozo:Dolgozo
    {
        public string muszak {  get; set; }

        public FizikaiDolgozo(string nev,string azonosito,int ber,string muszak):base(nev,azonosito,ber)
        {
            this.muszak = muszak;
        }

        public override void KiirInformacio()
        {
            base.KiirInformacio();
            Console.WriteLine("Műszak: "+muszak);
        }
        public void Dolgozik()
        {
            Console.WriteLine(nev + " fizikai munkát végez a(z) " + muszak+" műszakban!");
        }
    }
}

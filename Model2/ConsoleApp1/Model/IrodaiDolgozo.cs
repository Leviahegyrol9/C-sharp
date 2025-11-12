using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class IrodaiDolgozo:Dolgozo
    {
        public string osztaly {  get; set; }

        public IrodaiDolgozo(string nev,string azonosito,int ber,string osztaly):base(nev,azonosito,ber)
        {
            this.osztaly = osztaly;
        }

        public override void KiirInformacio()
        {
            base.KiirInformacio();
            Console.WriteLine("Osztály:"+osztaly);
        }
        public void Dolgozik()
        {
            Console.WriteLine(nev+" adminisztratív feladatokat lát el "+osztaly+" osztályon.");
        }
    }
}

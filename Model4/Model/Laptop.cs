using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4.Model
{
    public class Laptop : Eszkoz
    {
        public double AkkuKapacitas {  get; set; }
        public Laptop(string nev, double suly, int alapTeljesitmeny, double laptopKapacitas) : base(nev, suly, alapTeljesitmeny)
        {
            AkkuKapacitas = laptopKapacitas;
        }

        public override void TeljesitmenyNovel(int watt)
        {
            base.TeljesitmenyNovel(watt);
            AkkuKapacitas -= 200;
        }

        public void AkkukimelesMod()
        {
            AkkuKapacitas *= 1.2;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, akku: {AkkuKapacitas} mAh";
        }
    }
}

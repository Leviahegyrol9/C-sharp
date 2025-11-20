using Model4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a laptop nevét: ");
            string nl = Console.ReadLine();
            Console.Write("Adja meg a laptop tömegét: ");
            double sl = double.Parse(Console.ReadLine());
            Console.Write("Adja meg a laptop teljesítményét: ");
            int tl = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a laptop akkukapacitását: ");
            double akl = int.Parse(Console.ReadLine());

            Laptop laptop = new Laptop(nl, sl, tl, akl);

            Console.Write("Adja meg a telefon nevét: ");
            string nm = Console.ReadLine();
            Console.Write("Adja meg a telefon tömegét: ");
            double sm = double.Parse(Console.ReadLine());
            Console.Write("Adja meg a telefon teljesítményét: ");
            int tm = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a telefon jelerősség: ");
            double jm = int.Parse(Console.ReadLine());

            Okostelefon okost = new Okostelefon(nm, sm, tm, jm);

            Console.Write("Súlyváltozás: ");
            int sulyvalt = int.Parse(Console.ReadLine());
            Console.Write("Teljesítményváltozás: ");
            int teljesítményvalt = int.Parse(Console.ReadLine());

            laptop.SulyNovel(sulyvalt);
            laptop.TeljesitmenyNovel(teljesítményvalt);

            okost.SulyNovel(sulyvalt);
            okost.TeljesitmenyNovel(teljesítményvalt);

            Console.WriteLine(laptop);
            Console.WriteLine(okost);
        }
    }
}

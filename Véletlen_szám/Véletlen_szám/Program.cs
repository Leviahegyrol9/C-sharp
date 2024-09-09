using System;

namespace Véletlen_szám
{
    class Program
    {
        static void Main(string[] args)
        {
            Random vsz = new Random();
            int szam1;
            int szam2;
            szam1 = vsz.Next(10, 100);
            szam2 = vsz.Next(10, 100);
            Console.WriteLine("Az első szám: " + szam1);
            Console.WriteLine("A második szám: " + szam2);
            Console.WriteLine("Számok összege: {0}", szam1 + szam2);
            Console.WriteLine("Számok külömbsége: {0}", szam1 - szam2);
            Console.WriteLine("Számok szorzata: {0}", szam1 * szam2);
            Console.WriteLine("Számok hányadosa: {0}", (double)szam1 / szam2);
            //Console.WriteLine("Számok hányadosa: {0}", szam1 / szam2);
            Console.ReadKey();
        }
    }
}

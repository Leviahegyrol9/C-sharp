using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véletlen_szám_2
{
    internal class Program
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
            Console.WriteLine($"Számok összege: {szam1 + szam2}");
            Console.WriteLine($"Számok külömbsége: {szam1 - szam2}");
            Console.WriteLine($"Számok szorzata: {szam1 * szam2}");
            Console.WriteLine($"Számok hányadosa: {(double)szam1 / szam2}");
            Console.ReadKey();
        }
    }
}

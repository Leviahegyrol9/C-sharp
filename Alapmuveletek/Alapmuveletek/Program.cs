using System;

namespace Alapmuveletek
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam_1;
            int szam_2;
            Console.WriteLine("Kérem az első számot:");
            szam_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a második számot:");
            szam_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A számok összege: " + (szam_1 + szam_2));
            Console.WriteLine("A számok külömbsége: " + (szam_1 - szam_2));
            Console.WriteLine("A számok szorzata: " + (szam_1 * szam_2));
            Console.WriteLine("A számok hányadosa: " + (szam_1 / szam_2));
            Console.ReadKey();
        }
    }
}

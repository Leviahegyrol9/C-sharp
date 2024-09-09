using System;

namespace HowToMoney
{
    class Program
    {
        static void Main(string[] args)
        {
        double x;
        double t;
        double k;
        double j;
            Console.WriteLine("Kérem a betenni kívánt tőke összegét forintban: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem a lekötés idejét évben megadva: ");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem az éves katlábat %-ban megadva: ");
            k = Convert.ToDouble(Console.ReadLine());
            j = x * (1 + (k / 100) * t);
            Console.WriteLine("A jövőbeli összeg: {0}", j);
            Console.ReadKey();
        }
    }
}

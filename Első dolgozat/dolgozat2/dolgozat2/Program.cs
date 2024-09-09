using System;

namespace dolgozat2
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1;
            int r2;
            Console.WriteLine("Kérem az első értéket:");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a második értéket:");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Az eredő ellenállás: {0}", (r1 * r2) / (r1 + r2));
        }
    }
}

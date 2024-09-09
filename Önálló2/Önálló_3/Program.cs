using System;

namespace Önálló_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double v;
            Console.WriteLine("Kérem az első számot: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem a második számot: ");
            y = Convert.ToDouble(Console.ReadLine());
            v = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("A vektor hossza: {0}", v);
            Console.ReadKey();
        }
    }
}

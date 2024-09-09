using System;

namespace haromszog_terulete
{
    class Program
    {
        static void Main(string[] args)
        {
            double p;
            double q;
            double m;
            double T;
            Console.WriteLine("Kérem a szakasz hosszát: ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem a másik szakasz hosszát: ");
            q = Convert.ToDouble(Console.ReadLine());
            m = Math.Sqrt(p * q)
            T = ((p + q) * m)/2;
;           Console.ReadKey();
        }
    }
}

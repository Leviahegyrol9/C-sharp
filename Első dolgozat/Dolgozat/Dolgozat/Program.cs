using System;

namespace Dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1;
            double r2;
            double T;
            Console.WriteLine("Kérem az első értéket:");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem a második értéket:");
            r2 = Convert.ToDouble(Console.ReadLine());
            T = Math.PI * (Math.Pow(r1, 2) - (Math.Pow(r2, 2))) / 2;
            Console.WriteLine("Terület: {0}", T);
            
            
        }
    }
}

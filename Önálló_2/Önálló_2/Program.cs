using System;

namespace Önálló_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Kérem a számot:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(x, 4)/Math.PI);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09._03._fuggveny_
{
    internal class Program
    {
        static double almapure(double alma, double korte)
        {
            return 1.3 * (alma + korte);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1);
                Console.Write("Hány kg almát használtak: ");
                double almak = Convert.ToDouble(Console.ReadLine());

                Console.Write("Hány kg körtét használtak: ");
                double korte = Convert.ToDouble(Console.ReadLine());

                double osszsuly = almapure(almak, korte);
                osszsuly = Math.Round(osszsuly, 3);

                Console.Clear();

                Console.WriteLine($"Az almapüre mennyisége {osszsuly} kg");
                Console.WriteLine($"Az almapüre mennyisége {osszsuly:n2} kg");

                Thread.Sleep(2500);
                Console.Clear();

            }
            Console.ReadLine();
        }
    }
}

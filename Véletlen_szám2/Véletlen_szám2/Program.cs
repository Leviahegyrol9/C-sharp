using System;

namespace Véletlen_szám2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kezdo;
            int veg;
            Random vsz = new Random();
            Console.WriteLine("Kérem az intervallum kezdetét!");
            kezdo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem az intervallum végét!");
            veg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A véletlenszámok:");
            Console.WriteLine(vsz.Next(kezdo, veg));
            Console.WriteLine(vsz.Next(kezdo, veg));
            Console.WriteLine(vsz.Next(kezdo, veg));
            Console.ReadKey();
        }
    }
}

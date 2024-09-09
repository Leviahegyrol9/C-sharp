using System;

namespace Önálló
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rn = new Random();
            double szam1;
            double szam2;
            szam1 = rn.Next(10, 100);
            szam2 = rn.Next(10, 100);
            Console.WriteLine("Az első szám értéke: {0}\nA második szám értéke: {1}", szam1, szam2);
            Console.WriteLine(Math.Sqrt(Math.Pow(szam1, 2) + szam2));
            Console.ReadKey();
        }
    }
}

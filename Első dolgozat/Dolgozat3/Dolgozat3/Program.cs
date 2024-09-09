using System;

namespace Dolgozat3
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double a;
            double T;
            double K;
            Console.WriteLine("Kérem a kör sugarát:");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem a központi szöget:");
            a = Convert.ToDouble(Console.ReadLine());
            T = (Math.Pow(r, 2) * Math.PI) / 3;
            K = (2 * r * Math.PI) /3;
            Console.WriteLine("A körszelet területe: {0}\nA körszelet kerülete: {1}", T, K);
        }
    }
}

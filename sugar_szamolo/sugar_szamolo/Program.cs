using System;

namespace sugar_szamolo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double m;
            double ma;
            double A;
            double V;
            double r;
            Console.WriteLine("Kérem az alap hosszát:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem a gúla magasságát:");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem az oldallap magasságát:");
            ma = Convert.ToDouble(Console.ReadLine());
            A = Math.Pow(a, 2) + ((4 * a * ma) / 2);
            V = (Math.Pow(a, 2) * m) / 3;
            r = (3 * V) / A;
            Console.WriteLine("A felszin: {0}\nA térfogat: {1}\nA gúlába írható gömb sugara: {2}", A, V, r);
            Console.ReadKey();
        }
    }
}

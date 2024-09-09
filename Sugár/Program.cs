using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sugár
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem az alap hosszát:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem a gúla magasságát:");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem az oldallap magasságát:");
            double ma = Convert.ToDouble(Console.ReadLine());
            double A = Math.Pow(a, 2) + ((4 * a * ma) / 2);
            double V = (Math.Pow(a, 2) * m) / 3;
            double r = (3 * V) / A;
            Console.WriteLine($"A felszin: {A}\nA térfogat: {V}\nA gúlába írható gömb sugara: {r}");
            Console.ReadKey();

        }
    }
}

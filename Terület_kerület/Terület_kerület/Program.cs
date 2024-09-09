using System;

namespace Terület_kerület
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldal;
            int ter;
            int ker;
            Console.WriteLine("Kérem a négyzet oldal hosszúságát:");
            oldal = Convert.ToInt32(Console.ReadLine());
            ter = oldal * oldal;
            ker = 4 * oldal;
            Console.WriteLine("A négyzet területe:" + ter);
            Console.WriteLine("A négyzet kerülete:" + ker);
            Console.ReadKey();
        }
    }
}

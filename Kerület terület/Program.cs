using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerület_terület
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a négyzet oldal hosszúságát:");
            int oldal = Convert.ToInt32(Console.ReadLine());
            int ter = oldal * oldal;
            int ker = 4 * oldal;
            Console.WriteLine($"A négyzet területe: {ter}");
            Console.WriteLine($"A négyzet kerülete: {ker}");
            Console.ReadKey();
        }
    }
}

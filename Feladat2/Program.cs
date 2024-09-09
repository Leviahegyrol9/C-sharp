using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] { "Hétfő", "Kedd", "Szerda", "Csütörtök", "Péntek" };
            int napiora = 0;
            int heti = 0;
            int napszam = 1;
            for (int i = 0; i < 5; i++) 
            {
                Console.Write($"{napszam}.");
                napszam++;
                Console.Write("A " + days[i]+"-i napon hány órád van: ");
                napiora = Convert.ToInt32(Console.ReadLine());
                heti += napiora;
            }
            Console.WriteLine($"A heti óraszám {heti}.");
            Console.ReadLine();
        }
    }
}

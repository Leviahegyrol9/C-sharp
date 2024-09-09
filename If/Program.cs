using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mennyiseg;
            Random vsz = new Random();
            int szorzat = 0;
            Console.Write("Kérem a búza mennyiségét: ");
            mennyiseg = Convert.ToInt32(Console.ReadLine());
            szorzat = mennyiseg * vsz.Next(5, 15);
            Console.WriteLine($"A várható érték: {szorzat}");
            if (szorzat < 8)
            {
                Console.WriteLine("Átlag alatti!");
            }
            else if (szorzat <= 12)
            {
                Console.WriteLine("Átlagos!");
            }
            else if (szorzat <= 15)
            {
                Console.WriteLine("Átlag feletti!");
            }
            else
            {
                Console.WriteLine("Magasan átlag feletti!");
            }
            Console.ReadKey();
        }
    }
}

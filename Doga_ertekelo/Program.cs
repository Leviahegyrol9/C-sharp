using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga_ertekelo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a nevét: ");
            string name = Console.ReadLine();

            Console.Write("Kérem a dolgozat érdemjegyét: ");
            int mark = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (mark == 5)
            {
                Console.WriteLine($"Gratulálunk, {name}, az érdemjegyhez! ({mark})");
            }
            else if (mark == 4)
            {
                Console.WriteLine($"Gratulálunk, {name}, az érdemjegyhez! ({mark})");
            }
            else if (mark == 3)
            {
                Console.WriteLine($"Gratulálunk, {name}, az alapok megvannak! ({mark})");
            }
            else if (mark == 2)
            {
                Console.WriteLine($"Gratulálunk, {name}, sikeresen túlélted! ({mark})");
            }
            else
            {
                Console.WriteLine($"Sajnos ez nem sikerült, {name} ({mark})");
            }

            Console.ReadKey();
        }
    }
}

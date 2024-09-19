using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool isNumber = false;

            do
            {
                Console.Write("Adjon meg egy számot 0 - 9 közt: ");
                string input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);

                if (!isNumber)
                {
                    Console.WriteLine("Nem számot adott meg!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else if (number < 0 || number > 9)
                {
                    Console.WriteLine("A megadott értek nincs a tartományban!");
                    Thread.Sleep(2500);
                    Console.Clear();

                }
            }
            while (!isNumber || number < 0 || number > 9);

            Console.WriteLine($"A beolvasott szám: {number}");

            Console.ReadKey();
        }
    }
}

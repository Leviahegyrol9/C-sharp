using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConvertToBinary;

namespace Teszt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Haladunk");
            bool isNumber;
            string text = string.Empty;

            do
            {
                Console.Write("Kérem a számot: ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out int number);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else
                {
                text = ConvertToBinary.ConvertToBinary.ConvertToBinaryMethod(number);
                }

            } while(!isNumber);
            
            Console.Clear();
            Console.WriteLine($"Binárisan: {text}");
            Console.ReadKey();
        }
    }
}

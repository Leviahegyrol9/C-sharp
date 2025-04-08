using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int number;
            bool isNumber;

            do
            {
                Console.Write("1 - Git pull\n2 - Git push\nVálasztás: ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out number);

                if (!isNumber)
                {
                    Console.WriteLine("Nem számot adott meg!");
                    await Task.Delay(2000);
                }
                else if (number > 2 || number < 1)
                {
                    Console.WriteLine("Nincs ilyen opció!");
                    await Task.Delay(2000);
                }

                Console.Clear();

            } while (!isNumber || number > 2 || number < 1);

            switch (number)
            {
                case 1:
                    break;

                case 2:
                    break;
            }
        }
    }
}

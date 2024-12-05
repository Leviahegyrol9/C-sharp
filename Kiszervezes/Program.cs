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
            bool isNumber;
            string fileName = "adatok.txt";
            int[] oktetek = new int[4];
            List<string> texts = new List<string>();
            int counter = 0;
            int number;

            do
            {

                Console.Write($"Kérem adja meg az {counter + 1}. oktetet az ip-címből (0 és 255 között): ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out number);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else if (number < 0 || number > 255)
                {
                    Console.Write("Nincs ilyen szám a tartományban!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else
                {
                    oktetek[counter] = number;
                    texts.Add(ConvertToBinary.Methods.ConvertToBinaryMethod(number));
                    counter++;                   
                }

            } while(!isNumber || counter > 3 || number < 0 || number > 255);

            int option;


            do
            {
                Console.Write("1 - Hozzáírás a file-hoz\n2 - Új file létrehozása\n\nOpció: ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out option);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else if (number < 1 || number > 2)
                {
                    Console.Write("Nincs ilyen szám a tartományban!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else
                {
                    oktetek[counter] = number;
                    texts.Add(ConvertToBinary.Methods.ConvertToBinaryMethod(number));
                    counter++;
                }
            } while (!isNumber || number < 1 || number > 2);

            Console.ReadKey();
        }
    }
}

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
            List<string> ipAddresses = new List<string>();
            int counter = 0;
            int ip;

            do
            {

                Console.Write($"Kérem adja meg az {counter + 1}. oktetet az ip-címből (0 és 255 között): ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out ip);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                }
                else if (ip < 0 || ip > 255)
                {
                    Console.Write("Nincs ilyen szám a tartományban!");
                    Thread.Sleep(2500);
                }
                else
                {
                    ipAddresses.Add(ConvertToBinary.Methods.ConvertToBinaryMethod(ip, counter));
                    counter++;                   
                }
                Console.Clear();

            } while(!isNumber || counter < 4 || ip < 0 || ip > 255);

            int prefix;

            do
            {
                Console.Write("Adja meg a prefixet\n\nOpció: ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out prefix);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                }
                else if (prefix < 1 || prefix > 31)
                {
                    Console.Write("Nincs ilyen szám a tartományban!");
                    Thread.Sleep(2500);
                }
                Console.Clear();

            } while (!isNumber || prefix < 1 || prefix > 31);

            ConvertToBinary.Methods.ModifyList(prefix, ipAddresses);

            bool append;
            int choice;

            do
            {
                Console.Write("1 - Hozzáírás a file-hoz\n2 - Új file létrehozása\n\nOpció: ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out choice);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                }
                else if (choice < 1 || choice > 2)
                {
                    Console.Write("Nincs ilyen szám a tartományban!");
                    Thread.Sleep(2500);
                }
                Console.Clear();

            } while (!isNumber || choice < 1 || choice > 2);

            if (choice == 1)
            {
                append = true;
            }
            else
            {
                append = false;
            }

            bool success = ConvertToBinary.Methods.WriteToFile(fileName, ipAddresses, append);

            if (success)
            {
                Console.WriteLine($"Az {fileName} állomány sikeresen frissítve!");
            }
            else
            {
                Console.WriteLine($"Az {fileName} állományt nem sikerült frissíteni!");
            }

            Console.ReadKey();
        }
    }
}

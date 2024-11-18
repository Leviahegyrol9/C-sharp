using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Osztalyzatok
{
    internal class Program
    {
        static List<string> textToList(string filePath)
        {
            // A fájl beolvasása
            string[] lines = File.ReadAllLines(filePath);  // Minden sor beolvasása

            // Tömbök a nevekre és a befizetett összegekre

            List<string> names = new List<string>(lines.Length);

            // A fájl sorainak feldolgozása
            for (int i = 0; i < lines.Length; i++)
            {
                names.Add(lines[i]);  // Sor felbontása névre és összegre
            }

            return names;
        }

        static void Main(string[] args)
        {
            int option = 0;
            bool isNumber = false;


            while (!isNumber || (option > 2 || option < 1))
            {
                Console.WriteLine("1. Létrehozás: Adatok generálása és fájlba mentése.\n2. Elemzés: Az osztalyzatok.txt és a tantárgyakat tartalmazó fájl alapján elemzés végrehajtása.");
                Console.Write("Írja be a választott opciót: ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out option);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else if (option > 2 || option < 1)
                {
                    Console.Write("Nincs ilyen opció!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
            }
            string filePath = "tantargyak.txt";

            List<string> subjects = textToList(filePath);

            Console.ReadKey();
        }
    }
}

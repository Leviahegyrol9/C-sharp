using System;
using System.Collections;
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

            List<string> datas = new List<string>(lines.Length);

            // A fájl sorainak feldolgozása
            for (int i = 0; i < lines.Length; i++)
            {
                datas.Add(lines[i]);
            }

            return datas;
        }

        static void Main(string[] args)
        {
            int option = 0;
            bool isNumber = false;
            Random random = new Random();
            Dictionary<string, List<int>> namesAndMarks = new Dictionary<string, List<int>>();

            string filePath = "tantargyak.txt";
            List<string> subjects = textToList(filePath);

            filePath = "magyar_nevek.txt";
            List<string> names = textToList(filePath);


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

            if (option == 1)
            {
                using (StreamWriter writer = new StreamWriter("osztalyzatok.txt"))
                {
                    for (int i = 0; i < names.Count(); i++)
                    {
                        writer.Write($"{names[i]}");

                        for (int j = 0; j < subjects.Count(); j++)
                        {
                            int mark = random.Next(0, 6);
                            writer.Write($";{mark}");
                        }
                        writer.WriteLine();
                    }
                }
            }
            else if (option == 2)
            {
                List<int> tempMarks = new List<int>();
                // A fájl beolvasása
                string[] lines = File.ReadAllLines("osztalyzatok.txt");  // Minden sor beolvasása

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(';');
                    string name = parts[0].Trim();
                    for (int j = 1; j < parts.Length; j++)
                    {
                        tempMarks.Add(int.Parse(parts[j].Trim()));
                    }
                    namesAndMarks.Add(name, tempMarks);
                }

                foreach (KeyValuePair<string, List<int>> data in namesAndMarks)
                {
                    Console.WriteLine($"{data.Key}, jegyek átlaga: {data.Value.Sum()/subjects.Count()}");
                }
            }

            Console.ReadKey();
        }
    }
}

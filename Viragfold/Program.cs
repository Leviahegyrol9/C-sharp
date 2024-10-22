using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viragfold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<string> floors = new List<string>();
            List<string> floorSum = new List<string>();
            List<int> flowerbed = new List<int>();
            int counter = 0;
            int floorCounter = 1;
            int sum = 0;
            int floorA = 0;
            int floorB = 0;

            for (int i = 1; i < 61; i++)
            {
                if(i <= 30)
                {
                    if(i % 3 == 0)
                    {
                        floorA = i / 3;
                    }
                    else
                    {
                        floorA = i / 3 + 1;
                    }
                    floors.Add($"A-{floorA}-{i}");
                }
                else
                {
                    counter++;
                    if (counter % 3 == 0)
                    {
                        floorB = counter / 3;
                    }
                    else
                    {
                        floorB = counter / 3 + 1;
                    }
                    floors.Add($"B-{floorB}-{counter}");

                }
            }

            for (int i = 0; i < floors.Count(); i++) 
            {
                flowerbed.Add(rnd.Next(0,201));
                sum += flowerbed[i];
            
                Console.WriteLine(floors[i] + ": " + flowerbed[i] + " liter");
                if ((i + 1) % 3 == 0)
                {
                    floorSum.Add($"{floorCounter}. emeleten {sum} kg.");
                    floorCounter++;
                    sum = 0;
                }
                if(floorCounter % 11 == 0)
                {
                    floorCounter = 1;
                }

                if (i == 29)
                {
                    Console.WriteLine();
                }

            }
            int all = flowerbed.Sum();

            Console.WriteLine($"\nAz egész rendelés: {all} liter");

            int twenty = all / 20;
            all = all % 20;
            int ten = all / 10;
            all = all % 10;
            int five = all / 5;
            all = all % 5;
            int one = all;

            Console.WriteLine($"\nÖsszesítés:");
            Console.WriteLine($"20 as csomagból {twenty} db van");
            Console.WriteLine($"10 es csomagból {ten} db van");
            Console.WriteLine($"5 ös csomagból {five} db van");
            Console.WriteLine($"1 es csomagból {one} db van\n");

            counter = 0;

            foreach (string f in floorSum)
            {
                counter++;
                if(counter < 11)
                {
                    Console.Write("A-");
                }
                else
                {
                    Console.Write("B-");
                }

                Console.WriteLine(f);

                if (counter == 10)
                {
                    Console.WriteLine();
                }

            }


            Console.ReadKey();
        }
    }
}
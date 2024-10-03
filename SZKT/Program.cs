using System;
using System.Collections.Generic;
using System.Linq;

namespace SZKT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tram1 = new List<string>() { "Szegedi vasútállomás", "Galamb utca", "Bécsi körút", "Aradi vértanuk tere", "Somogyi utca", "Széchényi tér", "Anna-kút", "Rókusi templom", "Tavasz utca", "Damjanich utca", "Vásárhelyi Pál utca", "Pulz utca", "Rókusi Vasútállomás" };
            int tram1Time = 17;

            List<string> tram2 = new List<string>() { "Vértó", "Bálint Sándor utca", "Rókusi víztorony", "Szatymazu utca", "Vásárhelyi Pál út", "Damjanich utca", "Tavasz utca", "Rókusi templom", "Anna-kút", "Széchenyi tér", "Somogyi utca", "Aradi vértanúk tere", "Bécsi krt.", "Bem utca", "Szeged vá." };
            int tram2Time = 18;

            List<string> tram3 = new List<string>() { "Tarján", "Budapesti krt.", "Deák Ferenc Gimnázium", "Rózsa utca", "Kecskeméti utca", "Brüsszeli krt.", "Szent György tér", "Glattfelder Gyula tér", "Anna-kút", "Tisza Lajos krt. (Károlyi u.), ", "Dugonics tér", "Londoni krt. (Kálvária sgt.)", "Veresács u.", "Kálvária tér", "II. Kórház", "vadaspark", "Belvárosi temető", "Belvárosi temető II. kapu", "Kereskedő köz", "Fonógyári út" };
            int tram3Time = 16;

            List<string> tram3F = new List<string>() { "Tarján", "Budapesti krt.", "Deák Ferenc Gimnázium", "Rózsa utca", "Kecskeméti utca", "Brüsszeli krt.", "Szent György tér", "Glattfelder Gyula tér", "Anna-kút", "Tisza Lajos krt. (Károlyi u.), ", "Dugonics tér", "Londoni krt. (Kálvária sgt.)", "Veresács u.", "Kálvária tér", "II. Kórház", "Vadaspark" };
            int tram3FTime = 24;

            List<string> tram4 = new List<string>() { "Szalámigyár", "Szabadkai út", "Vám tér", "Szivárvány kitérő", "Vitéz utca", "Dugonics tér", "Tisza Lajos krt. (Károlyi u.)", "Anna-kút", "Glattfelder Gyula tér", "Szent György tér", "Brüsszeli krt.", "Kecskeméti utca", "Rózsa utca", "Deák Ferenc Gimnázium", "Budapesti krt.", "Tarján" };
            int tram4Time = 16;

            List<int> numbers = new List<int>() { tram1Time, tram2Time, tram3Time, tram3FTime, tram4Time };
            List<string> trains = new List<string>() { "1", "2", "3", "3F", "4" };

            

            int minTravelTime = CalculateMin(numbers);
            int maxTravelTime = CalculateMax(numbers);
            

            string textMax = null;
            string textMin = null;

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] == minTravelTime)
                {
                    textMin = $"A legrövidebb menetidejű villamos: {trains[i]}";
                }

                else if (numbers[i] == maxTravelTime)
                {
                    textMax = $"A leghoszabb menetidejű villamos: {trains[i]}";
                }
            }


            Console.WriteLine($"Az 1-es villamos átlagosan {AverageCalculate(tram1, tram1Time):n1} perc alatt ér egy megállóhoz.");
            Console.WriteLine($"A 2-es villamos átlagosan {AverageCalculate(tram2, tram2Time):n1} perc alatt ér egy megállóhoz.");
            Console.WriteLine($"A 3-as villamos átlagosan {AverageCalculate(tram3, tram3Time):n1} perc alatt ér egy megállóhoz.");
            Console.WriteLine($"A 3F-es villamos átlagosan {AverageCalculate(tram3F, tram3FTime):n1} perc alatt ér egy megállóhoz.");
            Console.WriteLine($"A 4-es villamos átlagosan {AverageCalculate(tram4, tram4Time):n1} perc alatt ér egy megállóhoz.\n");

            Console.WriteLine($"Az 1-es villamos {tram1Time} perc alatt ér a végállomáshoz.");
            Console.WriteLine($"A 2-es villamos {tram2Time} perc alatt ér a végállomáshoz.");
            Console.WriteLine($"A 3-as villamos {tram3Time} perc alatt ér a végállomáshoz.");
            Console.WriteLine($"A 3F-es villamos {tram3FTime} perc alatt ér a végállomáshoz.");
            Console.WriteLine($"A 4-es villamos {tram4Time} perc alatt ér a végállomáshoz.\n");

            Console.WriteLine(textMin);
            Console.WriteLine(textMax);

            Console.ReadKey();
        }

        static double AverageCalculate(List<string> tram, int time)
        {
            return (double)time / tram.Count();
        }

        static int CalculateMin(List<int> numbers)
        {
            int min = numbers[0];

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }

            }
            return min;
        }

        static int CalculateMax(List<int> numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }

            }
            return max;
        }
    }
}

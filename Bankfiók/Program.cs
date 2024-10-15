using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankfiók
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10] { "Ügyfél0", "Ügyfél1", "Ügyfél2", "Ügyfél3", "Ügyfél4", "Ügyfél5", "Ügyfél6", "Ügyfél7", "Ügyfél8", "Ügyfél9" };
            List<double> averages = new List<double>();
            int[,] values = new int[10, 12];

            // Tömb megtöltése
            Random rnd = new Random();
            for (int i = 0; i < names.Count(); i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    values[i, j] = rnd.Next(-500000, 1000001);
                }
            }

            Console.Write("Név\t\tJan\tFeb\tMár\tÁpr\tMáj\tJún\tJúl\tAug\tSzep\tOkt\tNov\tDec");
            Console.WriteLine();
            for (int i = 0; i < names.Count(); i++) // Értékek kiíratása és személyenkénti átlag kiszámítása
            {
                Console.Write($"{names[i]}\t\t");
                int yearlySum = 0;

                for (int j = 0; j < 12; j++)
                {
                    Console.Write($"{values[i, j]}\t");
                    yearlySum += values[i, j];
                }

                double average = yearlySum / 12.0;
                averages.Add(average);
                Console.WriteLine();
            }

            // Atlagos záróegyenlegek kiírása
            Console.WriteLine("\nAz átlagos záróegyenlegek:");
            for (int i = 0; i < names.Count(); i++)
            {
                Console.WriteLine($"{names[i]}: {averages[i]:c2}");
            }

            // Havi záróegyenlegek kiírása
            Console.WriteLine("\nA bankfiók havi záróegyenlegei:");
            for (int i = 0; i < 12; i++)
            {
                int monthlySum = 0;
                for (int j = 0; j < names.Count(); j++)
                {
                    monthlySum += values[j, i];
                }
                Console.WriteLine($"Hónap {i + 1}: {monthlySum:c0}");
            }

            // Melyik ügyfél volt a legkevésbé kiköltekezett az éves átlageredménye szeint?
            int minIndex = averages.IndexOf(averages.Max());
            Console.WriteLine($"\nA legkevésbé kiköltekezett ügyfél: {names[minIndex]}.");

            // Melyik hónap a legjobb a banknak?
            int bestMonthCount = 0;
            int minMonthlySum = int.MaxValue;

            for (int i = 0; i < 12; i++)
            {
                int monthlySum = 0;
                for (int j = 0; j < names.Count(); j++)
                {
                    monthlySum += values[j, i];
                }

                if (monthlySum < minMonthlySum)
                {
                    minMonthlySum = monthlySum;
                    bestMonthCount = i;
                }
            }

            Console.WriteLine($"\nA bank számára a legjobb hónap: {bestMonthCount + 1}.");

            Console.ReadKey();
        }
    }
}

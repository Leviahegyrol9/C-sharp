using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Rangsor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> points = new List<double>();
            double minNumber = 0;
            double maxNumber = 5;
            double number;

            while (true)
            {
                Console.Write($"Kérem a pontszámot [{minNumber} - {maxNumber} ig] (Enter a kilépés!): ");
                string input = Console.ReadLine().Replace(".", ",");

                bool isWhiteSpace = string.IsNullOrWhiteSpace(input);

                if (isWhiteSpace)
                {
                    Console.Clear();
                    break;
                }

                bool isDouble = double.TryParse(input, out number);

                if (isDouble)
                {
                    if (number >= minNumber && number <= maxNumber)
                    {
                        points.Add(number);
                    }
                    else
                    {
                        Console.Write($"A(z) {number} nincs benne az intervallumban!");
                        Thread.Sleep(2500);
                    }

                }
                else
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                }

                Console.Clear();
            }

            List<double> maxPoints = new List<double>(points);
            List<double> minPoints = new List<double>(points);

            if (points.Count() != 0)
            {
                Console.WriteLine("A legjobb pontszámok:");

                for (int i = 1; i <= 3; i++)
                {   
                    Console.WriteLine($"{i}. {maxPoints.Max()}");
                    maxPoints.Remove(maxPoints.Max());

                    if(maxPoints.Count() == 0)
                    {
                        break;
                    }
                }

                Console.WriteLine("\nA legroszabb pontszámok:");

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"{i}. {minPoints.Min()}");
                    minPoints.Remove(minPoints.Min());

                    if (minPoints.Count() == 0)
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.Write("Egy számot sem adott meg!");
            }

            Console.ReadKey();
        }
    }
}

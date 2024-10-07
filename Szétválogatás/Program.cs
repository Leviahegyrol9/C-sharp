using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szetvalogatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numbersCount = 40;
            int[] numbers = new int[numbersCount];
            int counter = 0;
            int negative = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                numbers[i] = rnd.Next(-5000, 5001);
            }

            Console.WriteLine("Negatív számok:");
            foreach (int i in numbers)
            {

                if (i < 0)
                {
                    counter++;
                    Console.Write($"{counter}. ");
                    if (counter < 10)
                    {
                        Console.Write(" ");
                    }
                    if (counter < 100)
                    {
                        Console.Write(" ");
                    }
                    if (counter < 1000)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(":");
                    Console.Write($" {i}\t");
                    if (counter % 5 == 0)
                    {
                        Console.Write("\n");
                    }
                }
            }
            negative = counter;
            counter = 0;

            Console.WriteLine("\n\nNemnegatív számok:");
            foreach (int i in numbers)
            {

                if (i > 0)
                {
                    counter++;
                    Console.Write($"{counter}. ");
                    if (counter < 10)
                    {
                        Console.Write(" ");
                    }
                    if (counter < 100)
                    {
                        Console.Write(" ");
                    }
                    if (counter < 1000)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(":");
                    Console.Write($" {i}\t");
                    if (counter % 5 == 0)
                    {
                        Console.Write("\n");
                    }
                }
            }

            double negativePercent = (double)negative / numbers.Length;

            Console.WriteLine($"\n\nA negativ számok százaléka {negativePercent:p2}");



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaláló
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int finish = rnd.Next(1,100);
            int choice;
            int counter = 0;
            do
            {   
                counter++;
                Console.Write("Tippeld meg a számot: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice > finish)
                {
                    Console.WriteLine("A szám kisebb!");
                }
                else if (choice < finish)
                {
                    Console.WriteLine("A szám nagyobb!");
                }
                if (choice != finish)
                {
                    System.Threading.Thread.Sleep(2000);
                }
                Console.Clear();
            } while (choice != finish);
            Console.WriteLine($"Gratulálunk eltaláltad!\nPróbálkozásaid száma: {counter}");
            Console.ReadKey();
        }
    }
}

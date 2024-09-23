using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Telefon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A szoftvert írta: Paplukács Levente, 2024.09.23");
            List<int> samsung = new List<int>();
            List<int> apple = new List<int>();
            List<int> etc = new List<int>();
            double samsungAverage = 0;
            double appleAverage = 0;
            double etcAverage = 0;
            double sum = 0;

            int number = 0;
            int students = 0;
            bool isNumber = false;

            do
            {
                Console.Write("Adja meg az osztály létszámát: ");
                string input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);

                if (!isNumber)
                {
                    Console.WriteLine("Nem számot adott meg!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else
                {
                    students = Convert.ToInt32(input);
                }
            }
            while (!isNumber);

            for (int i = 0; i < students; i++)
            {
                Console.Clear();
                Console.Write("Adja meg a telefon gyártóját: ");
                string manufacter = Console.ReadLine();

                Console.Write("Adja meg a telefon akkumlátor szintjét: ");
                int battery = Convert.ToInt32(Console.ReadLine());

                switch (manufacter.ToLower())
                {
                    case "samsung":
                        samsung.Add(battery);
                        break;
                    case "apple":
                        apple.Add(battery);
                        break;
                    default:
                        etc.Add(battery);
                        break;
                }

            }

            foreach (int item in samsung)
            {
                sum += item;

                samsungAverage = sum / samsung.Count();
            }

            sum = 0;

            foreach (int item in apple)
            {
                sum += item;

                appleAverage = sum / apple.Count();
            }

            sum = 0;

            foreach (int item in etc)
            {
                sum += item;

                etcAverage = sum / etc.Count();
            }

            Console.Clear();

            Console.WriteLine($"A samsung telefonok átlagos kapacitása {samsungAverage:N1}%");
            Console.WriteLine($"Az apple telefonok átlagos kapacitása {appleAverage:N1}%");
            Console.WriteLine($"Az egyéb telefonok átlagos kapacitása {etcAverage:N1}%");

            Console.ReadKey();
        }
    }
}

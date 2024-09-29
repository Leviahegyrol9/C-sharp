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
            string date = DateTime.Now.ToString("yyyy-MM-dd").Replace("-", ".");
            Console.WriteLine($"A szoftvert írta: Paplukács Levente, a mai dátum: {date}");

            List<int> samsung = new List<int>();
            List<int> samsungSize = new List<int>();

            List<int> apple = new List<int>();
            List<int> appleSize = new List<int>();

            List<int> etc = new List<int>();
            List<int> etcSize = new List<int>();

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

                Console.Write("Adja meg a telefon kijelző méretét: ");
                int size = Convert.ToInt32(Console.ReadLine());

                switch (manufacter.ToLower())
                {
                    case "samsung":
                        samsung.Add(battery);
                        samsungSize.Add(size);
                        break;
                    case "apple":
                        apple.Add(battery);
                        appleSize.Add(size);
                        break;
                    default:
                        etc.Add(battery);
                        etcSize.Add(size);
                        break;
                }
            }

            double samsungAverage = Calculate(samsung);
            double appleAverage = Calculate(apple);
            double etcAverage = Calculate(etc);

            double samsungAverageSize = Calculate(samsungSize);
            double appleAverageSize = Calculate(appleSize);
            double etcAverageSize = Calculate(etcSize);

            Console.Clear();
            Console.WriteLine($"A samsung telefonok átlagos kapacitása {samsungAverage:N1}%");
            Console.WriteLine($"Az apple telefonok átlagos kapacitása {appleAverage:N1}%");
            Console.WriteLine($"Az egyéb telefonok átlagos kapacitása {etcAverage:N1}%\n");

            Console.WriteLine($"A samsung telefonok átlagos kijelzőmérete {samsungAverageSize:N1} inch");
            Console.WriteLine($"Az apple telefonok átlagos kijelzőmérete {appleAverageSize:N1} inch");
            Console.WriteLine($"Az egyéb telefonok átlagos kijelzőmérete {etcAverageSize:N1} inch");

            Console.ReadKey();
        }

        public static double Calculate(List<int> deviceList)
        {
            double sum = 0;

            foreach (int item in deviceList)
            {
                sum += item;
            }

            return sum / deviceList.Count();
        }
    }
}

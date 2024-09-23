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
            //A szoftvert írta: Paplukács Levente, 2024.09.23
            Dictionary<string, int> phones = new Dictionary<string, int>();
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

                foreach (var item in phones)
                {
                    Console.WriteLine($"{item.Key} {item.Value}%");
                }

                Console.Write("Adja meg a telefon gyártóját: ");
                string manufacter = Console.ReadLine();

                Console.Write("Adja meg a telefon akkumlátor szintjét: ");
                int battery = Convert.ToInt32(Console.ReadLine());

                phones.Add(manufacter, battery);

            }

            Console.ReadKey();
        }
    }
}

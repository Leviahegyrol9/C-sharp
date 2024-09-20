using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<string> programs = new List<string>();
            //string[] programs = new string[] {};
            int student = random.Next(17,28);
            double all = 0;

            Console.WriteLine($"Az osztály létszáma: {student}");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Kérem a program nevét ({i + 1}): ");
                string program = Console.ReadLine();
                programs.Add(program);
            }

            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                int number = 0;
                bool isNumber = false;

                do
                {
                    Console.Write($"Kérem a program összegét ({programs[i]}): ");
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
                        double money = Convert.ToDouble(input);
                        all += money;
                    }
                }
                while (!isNumber || number < 0 || number > 9);

                Console.WriteLine($"A beolvasott szám: {number}");

            }
            Console.Clear();

            Console.WriteLine($"A teljes végösszeg {all:C2}, fejenként {all / student:C2}");

            Console.ReadKey();
        }
    }
}

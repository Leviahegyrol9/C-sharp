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


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Kérem a program nevét ({i + 1}): ");
                string program = Console.ReadLine();
                programs.Add(program);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Kérem a program összegét ({programs[i]}): ");
                double money = Convert.ToDouble(Console.ReadLine());
                all += money;
            }
            Console.WriteLine($"A teljes végösszeg {all:C2}, fejenként {all / student:C2}");

            Console.ReadKey();
        }
    }
}

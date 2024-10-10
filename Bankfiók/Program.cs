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
            string[] names = new string[10] { "Ügyfél1", "Ügyfél2", "Ügyfél3", "Ügyfél4", "Ügyfél5", "Ügyfél6", "Ügyfél7", "Ügyfél8", "Ügyfél9", "Ügyfél10" };

            List<int> averages = new List<int> ();
            List<int> sums = new List<int> ();
            int sum = 0;

            int[,] values = new int[10, 12];

            int counter = 0;

            Random rnd = new Random();
            for (int i = 0; i < names.Count(); i++)
            {

                for (int j = 0; j < 12; j++)
                {
                    values[counter, j] = rnd.Next(-500000, 1000000);

                }
                counter++;

            }

            counter = 0;

            for (int i = 0; i < names.Count(); i++)
            {

                Console.Write($"\n{names[i]}\t\t");

                for (int j = 0; j < 12; j++)
                {
                    Console.Write($"{values[counter, j]}\t");
                    summs.Add();
                }
                counter++;
                Console.WriteLine();
                

            }


            Console.ReadKey();
        }
    }
}

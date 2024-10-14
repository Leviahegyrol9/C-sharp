using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankiUgyfel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10] { "Ügyfél1", "Ügyfél2", "Ügyfél3", "Ügyfél4", "Ügyfél5", "Ügyfél6", "Ügyfél7", "Ügyfél8", "Ügyfél9", "Ügyfél10" };
            int[,] values = new int[10, 12];
            List<double> averages = new List<double> ();
            Random rnd = new Random();
            int sum = 0;

            for (int i = 0; i < names.Count(); i++)
            {
                for (int j = 0; j < 12; j++)
                    {
                        values[i,j] = rnd.Next(-500000, 1000000);
                    }
            }

            Console.WriteLine("Név\t\tJan\tFeb\tMar\tApr\tMaj\tJun\tJul\tAug\tSzep\tOkt\tNov\tDec");
            for (int i = 0; i < names.Count(); i++)
            {
                Console.Write($"\n{names[i]}\t\t");
                for (int j = 0; j < 12; j++)
                {
                    Console.Write($"{values[i, j]}\t");
                    sum += values[i, j];
                }
                double average =  (double)sum / 12;
                averages.Add(average);
                sum = 0;
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{names[i]}: {averages[i]:C2} az átlagos záróegyenleg");
            }

            Console.WriteLine();

            for (int i = 0; i < 12; i++)
            {
                double mountlyValue = 0;
                for (int j = 0; j < 10; j++)
                {
                    mountlyValue += values[j, i]; 
                }
                Console.WriteLine($"{i + 1} hónap bankfióki záró-egyenlege: {mountlyValue:C0}");
            }
            Console.ReadLine();
        }
    }
}

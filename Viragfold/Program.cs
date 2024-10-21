using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viragfold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<string> names = new List<string>();
            List<int> flowerbed = new List<int>();
            int counter = 0;

            for (int i = 1; i < 61; i++)
            {
                if(i <= 30)
                {
                    names.Add("A-" + i);
                }
                else
                {
                    counter++;
                    names.Add("B-" + counter);

                }
            }
            for (int i = 0; i < names.Count(); i++) 
            {
                flowerbed.Add(rnd.Next(0,201));
            }

            for (int i = 0; i < names.Count(); i++)
            {
                Console.WriteLine(names[i] + " " + flowerbed[i]);
            }
            Console.ReadKey();
        }
    }
}

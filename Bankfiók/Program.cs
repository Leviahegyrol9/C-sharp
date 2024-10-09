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

            int[,] namesAndValues = new int[10, 12];

            int counter = 0;

            Random rnd = new Random();
            for (int i = 0; i < names.Count(); i++)
            {

                for (int j = 0; j < 12; j++)
                {
                    namesAndValues[counter, j] = rnd.Next(-500000, 1000000);

                }
                counter++;

            }

            for (int i = 0; namesAndValues)
        }
    }
}

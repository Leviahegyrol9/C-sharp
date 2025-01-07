using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function;

namespace Számítógépek_kiosztása
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> classAndCapacity = new Dictionary<string, int>();

            for (int i = 1; i < 6; i++)
            {
                int capacity = Methods.GetNumberWithCondition($"Kérem adja meg a Terem{i} férőhelyét: ", 0, int.MaxValue);

                classAndCapacity = consoleServices.GetClassAndCapacity(classAndCapacity, $"Terem{i}", capacity);
            }

            

            Console.ReadKey();
        }
    }
}

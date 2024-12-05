using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertToName;

namespace Kiszervezes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem adja meg a nevét: ");
            string input = Console.ReadLine();
            string name = ConvertToName.Convert.Capitalize(input);

            Console.WriteLine("Üdvözöllek "+name);
            Console.ReadKey();
        }
    }
}

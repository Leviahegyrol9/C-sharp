using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia kicsi");
            Console.Write("Add meg a neved:");
            string name = Console.ReadLine();
            Console.Write("Add meg az életkorod:");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSzia kedves " + name + " eletkor: "+ age);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véletlen_Szám
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kezdo;
            int veg;
            Random vsz = new Random();
            Console.Write("Kérem az intervallum kezdetét: ");
            kezdo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem az intervallum végét: ");
            veg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A véletlen számok:");
            Console.WriteLine(vsz.Next(kezdo, veg));
            Console.WriteLine(vsz.Next(kezdo, veg));
            Console.WriteLine(vsz.Next(kezdo, veg));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagyobb_kisebb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az első számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a harmadik számot: ");
            int szam3 = Convert.ToInt32(Console.ReadLine());
            if ((szam1 > szam2) && (szam1 > szam3))
            {
                Console.WriteLine($"A legnagyobb szám: {szam1}");
            }
            else if ((szam2 > szam1) && (szam2 > szam3))
            {
                Console.WriteLine($"A legnagyobb szám: {szam2}");
            }
            else
            {
                Console.WriteLine($"A legnagyobb szám: {szam3}");
            }
            Console.ReadKey();
        }
    }
}

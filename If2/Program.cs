using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nyeremény;
            int szam1;
            int szam2;
            Console.Write("Kérem az első dobás értékét: ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a második dobás értékét: ");
            szam2 = Convert.ToInt32(Console.ReadLine());
            if (szam1 == szam2)
            {
                nyeremény = (szam1 + szam2) * 1000;
            }
            else if ((szam1 + szam2) % 2 == 0)
            {
                nyeremény = (szam1 + szam2) * 100;
            }
            else
            {
                nyeremény = 0;
            }
            Console.WriteLine($"A nyeremény: {nyeremény}");
            Console.ReadKey();
        }
    }
}

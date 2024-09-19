using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ma = 21;
            int tegnap = 18;
            var szoveg = string.Format("Ma {0} fok volt, tegnap pedig {1}", ma, tegnap);

            Console.WriteLine(szoveg);
            //példa a  Contains használata

            Console.WriteLine($"Pénz: {3148:C1}");
            Console.WriteLine($"Százalék: {0.123456:P3}");
            Console.WriteLine($"Általános: {132354:G}");
            Console.WriteLine($"Általános: {13.2354:N2}");
            Console.WriteLine($"Exponenciális: {132354:E}");
            Console.WriteLine($"Hexa: {255:X}");

            Console.Write("Add meg a neved:");
            string name = Console.ReadLine();

            Console.Write("Adj meg egy betut:");
            string letter = Console.ReadLine();

            if (name.ToLower().Contains(letter.ToLower()))
            {
                Console.WriteLine("Benne van");
            }
            else
            {
                Console.WriteLine("nincs benne");
            }
            Console.ReadKey();
        }
    }
}

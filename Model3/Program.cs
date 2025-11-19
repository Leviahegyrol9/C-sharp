using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Model3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a süteményt: ");
            string name = Console.ReadLine();
            Console.Write("Hozzávalók száma: ");
            int ingredient = int.Parse(Console.ReadLine());
            Console.Write("Idő: ");
            int time = int.Parse(Console.ReadLine());
            Console.Write("Cukor: ");
            int sugar = int.Parse(Console.ReadLine());

            Cookie cookies = new Cookie(name, ingredient, time, sugar);
        }
    }
}

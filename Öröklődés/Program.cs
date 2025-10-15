using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Öröklődés.Model;

namespace Öröklődés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Allat> lista = new List<Allat>
            {
                new HusevoAllat("steak", "triceratopsz", "dino", 30)
            };

            foreach (var item in lista)
            {
                item.KiirInformacio();
            }

            Console.ReadKey();
        }
    }
}

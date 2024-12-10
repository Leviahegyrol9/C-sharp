using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Diak.IO;

namespace Beolvasas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Model.Diak> diakok = DiakIO.ReadFile("adatok.txt");

            foreach(Model.Diak diak in diakok)
            {
                Console.WriteLine(diak);
            }

            Console.ReadKey();
        }
    }
}

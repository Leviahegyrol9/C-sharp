using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verseny
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = "idopontok.txt";

            List<Time> times = TimeIO.GetTImes(path);

            Console.WriteLine("a, 03:49");

        }
    }
}

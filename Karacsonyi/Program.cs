using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IO;

namespace Karacsonyi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "adatok.txt";

            Random random = new Random();

            List<Person> people = PersonIO.ReadFile(fileName);

            List<string> nameAndPresent = new List<string>();

            Console.ReadKey();
        }
    }
}

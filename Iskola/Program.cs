using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = "nevek.txt";
            List<Student> students = StudentIO.ReadStudentsFromFile(path);

            Console.WriteLine($"Az iskolába {students.Count} tanuló jár.");

            Student longestName = students.Single(name => name.Name.Length == students.Max(num => num.Name.Length));

            Console.WriteLine($"Leghosszabb nevű diák: {longestName.Name}\nA neve hossza: {longestName.Name.Length}");

            Dictionary<string, string> idAndPerson = new Dictionary<string, string>();

            Console.ReadKey();
        }
    }
}

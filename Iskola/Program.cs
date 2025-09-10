using System;
using System.Collections.Generic;
using System.IO;
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

            Dictionary<string, string> idAndPerson = GetIdAndPerson(students);

            Console.WriteLine($"Első tanuló: {idAndPerson.First().Key}: {idAndPerson.First().Value}");
            Console.WriteLine($"Utolsó tanuló: {idAndPerson.Last().Key}: {idAndPerson.Last().Value}");

            Console.Write("Adjon meg egy évet: ");
            int year = int.Parse(Console.ReadLine());

            List<Student> studentsWithYear = students.Where(s => s.Year == year).ToList();

            bool isSuccess = WriteStudentsToFile(studentsWithYear);

            Console.WriteLine($"{(isSuccess ? "Sikeres" : "Sikertelen")} fájlbaírás.");

            Console.Write("Adjon meg egy azonosítót: ");
            string id = Console.ReadLine();

            try
            {
                string idWithStudent = idAndPerson.Single(v => v.Value == id).Key;
                Console.WriteLine($"{id} azonosítóhoz {idWithStudent} tanuló tartozik.");
            }
            catch
            {
                Console.WriteLine("Nincs ilyen tanuló!");
            }

            List<Student> studentsEClass = students.Where(s => s.Class_ == "e").ToList();

            foreach (var student in studentsEClass.OrderBy(n => n.Name))
            {
                Console.WriteLine(student.Name);
            }

            Console.ReadKey();
        }

        static Dictionary<string, string> GetIdAndPerson(List<Student> students)
        {
            Dictionary<string, string> idAndPerson = new Dictionary<string, string>();

            HashSet<string> names = students.Select(s => s.Name).ToHashSet();

            foreach (string name in names)
            {
                idAndPerson[name] = string.Empty;
            }

            foreach (Student student in students)
            {
                string id = $"{student.Year.ToString().Last()}{student.Class_}{student.Name.Split(' ')[0].Substring(0,3)}{student.Name.Split(' ')[1].Substring(0,3)}";
                idAndPerson[student.Name] = id;

            }

            return idAndPerson;
        }
        static bool WriteStudentsToFile(List<Student> students)
        {
            try
            {
                using (StreamWriter sW = new StreamWriter("evdiak.txt"))
                {
                    foreach (Student student in students)
                    {
                        sW.WriteLine(student);
                    }

                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba tortént: " + e.Message);
                return false;
            }
            
        }
    }
}

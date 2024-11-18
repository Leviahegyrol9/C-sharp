using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Osztalyzatok
{
    internal class Program
    {
        static void PrintSubjectAverage(List<string> subjects)
        {
            // Tantárgyi átlag
            Dictionary<string, List<double>> subjectsAndMarks = new Dictionary<string, List<double>>();
            string[] lines = File.ReadAllLines("osztalyzatok.txt");

            foreach (string subject in subjects)
            {
                subjectsAndMarks[subject] = new List<double>();
            }

            foreach (string line in lines)
            {
                string[] oneLine = line.Split(';');

                for (int i = 1; i < oneLine.Length; i++)
                {
                    double mark = double.Parse(oneLine[i]);

                    if (mark != 0)
                    {
                        subjectsAndMarks[subjects[i - 1]].Add(mark);
                    }
                }
            }

            // Tantárgyi átlagok kiírása
            Console.WriteLine("\nTantárgyak átlagai:\n");

            foreach (KeyValuePair<string, List<double>> data in subjectsAndMarks)
            {
                Console.WriteLine($"{data.Key}: {data.Value.Sum() / data.Value.Count():N2}");
            }
        }
        static void PrintStudentAverage()
        {
            // Diákátlag
            Dictionary<string, List<double>> studentsAndMarks = new Dictionary<string, List<double>>();
            string[] lines = File.ReadAllLines("osztalyzatok.txt");

            foreach (string line in lines)
            {
                string[] oneLine = line.Split(';');
                string student = oneLine[0];

                List<double> tempMarks = new List<double>();

                for (int i = 1; i < oneLine.Length; i++)
                { 
                    if (double.Parse(oneLine[i]) != 0)
                    {
                        tempMarks.Add(double.Parse(oneLine[i]));
                    }
                }

                studentsAndMarks.Add(student, tempMarks);
            }

            // Átlagok kiírása
            foreach (KeyValuePair<string, List<double>> data in studentsAndMarks)
            {
                Console.WriteLine($"{data.Key}: {data.Value.Sum() / data.Value.Count():N2}");
            }
        }
        static List<string> ReadFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            List<string> datas = new List<string>();

            foreach (string line in lines)
            {
                datas.Add(line);
            }
           
            return datas;
        }

        static bool PrintToFile(List<string> names, List<string> subjects, string fileName)
        {
            Random random = new Random();

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        writer.Write($"{names[i]}");

                        for (int j = 0; j < subjects.Count; j++)
                        {
                            int mark = random.Next(0, 6);
                            writer.Write($";{mark}");
                        }
                        writer.WriteLine();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int option = 0;
            bool isNumber = false;

            List<string> subjects = ReadFile("tantargyak.txt");

            List<string> names = ReadFile("magyar_nevek.txt");

            while (!isNumber || (option > 2 || option < 1))
            {
                Console.WriteLine("1. Létrehozás: Adatok generálása és fájlba mentése.\n2. Elemzés: Az osztalyzatok.txt és a tantárgyakat tartalmazó fájl alapján elemzés végrehajtása.");
                Console.Write("\nÍrja be a választott opciót: ");
                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out option);

                if (!isNumber)
                {
                    Console.Write("Nem számot adott meg!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else if (option > 2 || option < 1)
                {
                    Console.Write("Nincs ilyen opció!");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
            }

            if (option == 1)
            {
                Console.Clear();

                string fileName = "osztalyzatok.txt";
                bool success = PrintToFile(names, subjects, fileName);

                if (success)
                {
                    Console.Write($"Az {fileName} állomány sikeresen létrehozva!");
                }
                else
                {
                    Console.Write($"Az {fileName} állományt nem sikerült létrehozni!");
                }
            }
            else if (option == 2)
            {
                Console.Clear();
                Console.WriteLine("Tanulók átlagai:\n");
                PrintStudentAverage();

                PrintSubjectAverage(subjects);
            }

            Console.ReadKey();

        }
    }
}

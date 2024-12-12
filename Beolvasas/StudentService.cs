using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Beolvasas
{
    public class StudentService
    {
        public static void PrintAllStudent(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
        public static List<Student> StudentsAboveAverage(List<Student> students, double average)
        {
            List<Student> aboveAverage = students.Where(student => student.Average > average).ToList();

            return aboveAverage;
        }

        public static bool WriteFile(string fileName, List<Student> students, bool append)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, append))
                {
                    foreach (Student student in students)
                    {
                        writer.WriteLine(student);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void CheckSuccess(string fileName, bool success)
        {
            if (success)
            {
                Console.WriteLine($"{fileName} állomány sikeresen létrehozva!");
                Thread.Sleep(2500);
            }
            else
            {
                throw new Exception($"{fileName} állományt nem sikerült létrehozni!");
            }
        }

        public static Dictionary<string, int> StudentsCategories(List<Student> students)
        {
            Dictionary<string, int> categories = new Dictionary<string, int>()
            {
                {"elégtelen", 0},
                {"elégséges", 0},
                {"közepes", 0},
                {"jó", 0},
                {"jeles", 0}
            };
            
            foreach (Student student in students)
            {
                if (student.Average >= 2.00 && student.Average <= 2.99)
                {
                    categories["elégséges"]++;
                }
                else if (student.Average >= 3.00 && student.Average <= 3.99)
                {
                    categories["közepes"]++;
                }
                else if (student.Average >= 4.00 && student.Average <= 4.99)
                {
                    categories["jó"]++;
                }
                else if (student.Average == 5)
                {
                    categories["jeles"]++;
                }
                else
                {
                    categories["elégtelen"]++;
                }
            }

            return categories;
        }
    }
}

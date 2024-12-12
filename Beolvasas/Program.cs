using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beolvasas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "adatok.txt";

            List<Student> students = DiakIO.ReadFile(fileName);

            //1 - Írjuk ki minden diák adatát a képernyőre!
            
            StudentService.PrintAllStudent(students);

            //2 - Hány diák jár az osztályba?

            Console.WriteLine($"\nAz osztályba {students.Count} tanuló jár.");

            //3 - Mennyi az osztály átlaga?

            double average = students.Average(student => student.Average);

            Console.WriteLine($"\nAz osztály átlaga: {average:n2}");

            //4 - Keressük a legtöbb pontot elért érettségizőt és írjuk ki az adatait a képernyőre.

            List<Student> bestStudents = students.Where(student => student.Average == students.Max(max => max.Average)).ToList();

            Console.WriteLine("\nA legtöbb pontot elért érettségizők:");

            foreach (Student student in bestStudents)
            {
                Console.WriteLine(student);
            }

            //5 - atlagfelett.txt allományba keressük ki azon tanulókat kiknek pontjai meghaladják az átlagot!

            List<Student> aboveAverage = StudentService.StudentsAboveAverage(students, average);

            bool success = StudentService.WriteFile("atlagfelett.txt", aboveAverage, false);

            Console.WriteLine();

            StudentService.CheckSuccess("atlagfelett.txt", success);

            //6 - Van e kitünő tanulónk?

            bool excellentStudent = students.Any(student => student.Average > 5);

            if (excellentStudent)
            {
                Console.WriteLine("\nVan kitűnő tanulónk!\n");
            }
            else
            {
                Console.WriteLine("\nNincs kitűnő tanulónk!\n");
            }

            /*
             7 - Hány elégtelen, elégséges, jó, jeles és kitünő tanuló van az osztályban?
                Értékhatárok:
	            - elégtelen, ha: 0.00 - 1.99
	            - elégséges, ha: 2.00 - 2.99
	            - jó, ha: 3.00 - 3.99
	            - jeles, ha: 4.00 - 4.99
	            - kitünő, ha: 5.00
            */

            Dictionary<string, int> categories = StudentService.StudentsCategories(students);

            foreach (KeyValuePair<string, int> student in categories)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Órarend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lessonCounter = 0;

            string[] days = new string[] { "Hétfőn", "Kedden", "Szerdán", "Csütörtökön", "Pénteken" };
            //string[] timetable = new string[] { };
            string[] lessons = new string[] { "magyar", "matek", "töri", "biosz", "kémia", "infó" };

            Console.Write("Hány napot szeretnél generálni: ");
            int dayCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < dayCount; i++)//napok váltakozása
            {
                Console.Write($"Hány órád legyen {days[i]}: ");
                int lesson = Convert.ToInt32(Console.ReadLine());

                for (int counter = 0; counter < lesson; counter++)//Órák váltakozása
                {
                    lessonCounter++
                    int index = random.Next(0, lessons.Length);
                    Console.WriteLine($"{counter + 1}.{lessons[index]}");
                }
            }
            Console.WriteLine($"Összesen {lessonCounter}db órád volt.");
            Console.ReadKey();
        }
    }
}

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
                int flip = 2;//1 első óra nincs; 2 utolsó ora nincs; 3 normál nap
                Console.Write($"Hány órád legyen {days[i]}: ");
                int lesson = Convert.ToInt32(Console.ReadLine());
                if (flip == 1)
                {
                    Console.WriteLine($"1. -");
                }
                else if (flip == 2)
                {
                    Console.WriteLine($"{lesson}. -");
                }

                for (int counter = 0; counter < lesson; counter++)//Órák váltakozása
                {
                    if (flip == 1)
                    {
                        int index = random.Next(0, lessons.Length);
                        Console.WriteLine($"{counter + 1}.{lessons[index]}");
                    }
                    else if (flip == 2)
                    {
                        int index = random.Next(0, lessons.Length);
                        Console.WriteLine($"{counter + 1}.{lessons[index]}");
                    }
                    else
                    {
                        int index = random.Next(0, lessons.Length);
                        Console.WriteLine($"{counter + 1}.{lessons[index]}");

                    }

                    lessonCounter++;
                }
            }
            Console.WriteLine($"Összesen {lessonCounter}db órád volt.");
            Console.ReadKey();
        }
    }
}

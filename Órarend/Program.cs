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
            string[] lessons = new string[] { "magyar", "matek", "töri", "biosz", "kémia", "infó" };

            Console.Write("Hány napot szeretnél generálni: ");
            int dayCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < dayCount; i++) // napok váltakozása
            {
                Console.Write($"Hány órád legyen {days[i]}: ");
                int lesson = Convert.ToInt32(Console.ReadLine());

                //0 - semmi, 1 - első óra nincs, 2 - utolsó óra nincs
                int flip = random.Next(0, 3);

                if (flip == 1)
                {
                    Console.WriteLine("1. -");
                }

                for (int counter = 0; counter < lesson; counter++) // Órák váltakozása
                {
                    lessonCounter++;

                    if (flip == 1 && counter == 0)
                    {
                        lessonCounter -= 1;
                        continue;
                    }

                    else if (flip == 2 && counter == lesson - 1)
                    {
                        lessonCounter -= 1;
                        Console.WriteLine($"{lesson}. -");
                        break;
                    }

                    int index = random.Next(0, lessons.Length);
                    Console.WriteLine($"{counter + 1}.{lessons[index]}");
                }

            }

            Console.Write($"\nÖsszesen {lessonCounter}db órád volt.");
            Console.ReadKey();
        }
    }
}
